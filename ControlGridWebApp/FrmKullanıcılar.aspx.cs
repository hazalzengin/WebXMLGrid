using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using DevExpress.Web;
using Sistem.DB.Model;
using Sistem.DB.Service;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Linq;
using System.Web.Services;
using DevExpress.Web.ASPxThemes;
using DayRenderEventArgs = System.Web.UI.WebControls.DayRenderEventArgs;

namespace ControlGridWebApp
{
    public partial class FrmKullanıcılar : Page
    {
        [System.ComponentModel.Bindable(true, System.ComponentModel.BindingDirection.TwoWay)]
        public DateTime SelectedDate { get; set; }
        private readonly hazaluserservice _userService;
        private readonly hazalusermenuservice _usermenuservice;
        public string ConnectionString = @"Data source=HAZAL;Initial Catalog=hazal;Integrated Security=True";
        public int _userId;
        private List<string> _columnOrder;
        public FrmKullanıcılar()
        {
            _usermenuservice = new hazalusermenuservice(ConnectionString);
            _userService = new hazaluserservice(ConnectionString);

        }
        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (lstSelectedDates.Items.FindByValue(e.Day.Date.ToShortDateString()) != null)
            {
                e.Cell.BackColor = System.Drawing.Color.Yellow; // veya istenen başka bir renk
                e.Cell.ForeColor = System.Drawing.Color.Black; // Yazı rengini değiştirmek için
            }
        }

        protected void btnApplySelection_Click(object sender, EventArgs e)
        {
            foreach (ListItem item in lstSelectedDates.Items)
            {
                DateTime selectedDate = DateTime.Parse(item.Value);
                Calendar1.SelectedDates.Add(selectedDate); // Takvime seçili tarihleri ekle
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {

           

            _userId = int.Parse(Request.QueryString["userId"]);

            if (!IsPostBack)
            {
                FillGridWithUserColumns();
            }
            if (Request["__EVENTTARGET"] == "AddColumn")
            {
                string columnName = Request["__EVENTARGUMENT"];
                AddColumnToGridView(columnName);
            }
        }


        private void AddColumnToGridView(string columnName)
        {
            GridViewDataTextColumn newColumn = new GridViewDataTextColumn();
            newColumn.FieldName = columnName;
            newColumn.Caption = columnName;
            Grid.Columns.Add(newColumn);
        }



        protected void gridPopupMenu_ItemClick(object source, DevExpress.Web.MenuItemEventArgs e)
        {
            switch (e.Item.Name)
            {
                case "SaveItem":
                    SaveGridPropertiesAsXml();
                    break;
            }
        }


        private void SaveGridPropertiesAsXml()
        {

            UpdateColumnOrder();
            WriteXML();
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('kaydedildi');", true);
            SaveColumnOrder();
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('kaydedildi');", true);
        }


        private void WriteXML()
        {
            try
            {
                string xmlFileName = Server.MapPath($"~/GridProperties{_userId}.xml");

                XmlDocument xmlDoc = new XmlDocument();
                XmlElement root = xmlDoc.CreateElement("GridProperties");
                xmlDoc.AppendChild(root);

                int index = 0;
                foreach (GridViewDataColumn column in Grid.VisibleColumns)
                {
                    if (column.VisibleIndex > 2)
                    {
                        XmlElement columnNode = xmlDoc.CreateElement("Column");
                        columnNode.SetAttribute("Name", column.FieldName);
                        columnNode.SetAttribute("Caption", column.Caption);
                        columnNode.SetAttribute("Width", column.Width.ToString());
                        columnNode.SetAttribute("VisibleIndex", index.ToString());

                        root.AppendChild(columnNode);
                        index++;
                    }
                }

                xmlDoc.Save(xmlFileName);

                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('XML dosyası başarıyla oluşturuldu.');", true);
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", $"alert('XML dosyası oluşturulurken hata oluştu: {ex.Message}');", true);
            }
        }





        protected void btnGuncellePage_Click(object sender, EventArgs e)
        {
            string userId = ((DevExpress.Web.ASPxButton)sender).CommandArgument;
            string username = editUsername.Text;
            string email = editEmail.Text;
            string password = editPassword.Text;
            int sonuc = _userService.Guncelle(new hazaluser
            {
                Id = _userId,
                username = username,
                email = email,
                password = password
            });
            string display = sonuc > 0 ? "Kullanıcı Bilgileri Güncellendi" : "Kullanıcı Eklerken hata oluştu";
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);

        }
        protected void btnFirstGrid_Click(object sender, EventArgs e)
        {
            List<string> columnOrder = new List<string> { "Id", "email", "password", "username" };
            for (int i = Grid.Columns.Count - 4; i >= 0; i--)
            {
                if (columnOrder.Contains(Grid.Columns[i].Caption))
                {
                    Grid.Columns.RemoveAt(i);
                }
            }

            foreach (var columnName in columnOrder)
            {
                GridViewDataTextColumn newColumn = new GridViewDataTextColumn();
                newColumn.FieldName = columnName;
                newColumn.Caption = columnName;
                Grid.Columns.Add(newColumn);
            }
            List<hazaluser> userList = _userService.GetAllUsers();
            Grid.DataSource = userList;
            Grid.DataBind();
        }

       



        protected void btnDelete_Click(object sender, EventArgs e)
        {
            ASPxButton btnDelete = sender as ASPxButton;
            int userId = Convert.ToInt32(btnDelete.CommandArgument);
            _userService.Sil(userId);

            FillGridWithUserColumns();

        }
        protected void btnYetki_Click(object sender, EventArgs e)
        {
            string userId = ((DevExpress.Web.ASPxButton)sender).CommandArgument;
            Response.Redirect("yetkipage.aspx?userId=" + userId);
        }

        protected void btnSaveUser_Click(object sender, EventArgs e)
        {
            int sonuc = _userService.Ekle(new hazaluser
            {
                username = txtUsername.Text,
                email = txtEmail.Text,
                password = txtPassword.Text
            });
            if (sonuc > 0)
            {
                string display = "Kullanıcı Eklendi";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);
                popupNewUser.ShowOnPageLoad = false;
                ClearPopupFields();

            }
            else
            {
                string display = "Kullanıcı Eklerken hata oluştu";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);
            }


        }
        private void UpdateColumnOrder()
        {
            _columnOrder = Grid.VisibleColumns.OfType<GridViewDataColumn>()
                                           .OrderBy(column => column.VisibleIndex)
                                           .Select(column => column.FieldName)
                                           .ToList();
        }


        private void SaveColumnOrder()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
                string query = "SELECT Column1 FROM grid_user WHERE UserId = @UserId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", _userId);
                object result = command.ExecuteScalar();


                if (result != DBNull.Value)
                {
                    string updateQuery = "UPDATE grid_user SET Column1 = @Column1 WHERE UserId = @UserId";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@UserId", _userId);
                    updateCommand.Parameters.AddWithValue("@Column1", string.Join(",", _columnOrder.Skip(4)));
                    updateCommand.ExecuteNonQuery();
                }
                else
                {
                    string query2 = "INSERT INTO grid_user (UserId, Column1) VALUES (@UserId, @Column1)";
                    SqlCommand command2 = new SqlCommand(query2, connection);
                    command2.Parameters.AddWithValue("@UserId", _userId);
                    command2.Parameters.AddWithValue("@Column1", string.Join(",", _columnOrder.Skip(4)));
                    command2.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", $"alert('XML dosyası oluşturulurken hata oluştu: {ex.Message}');", true);
            }
        }


        private void FillGridWithUserColumns()
        {
            try
            {
                string xmlFilePath = Server.MapPath($"~/GridProperties{_userId}.xml");


                if (File.Exists(xmlFilePath))
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(xmlFilePath);


                    //for (int i = 4; Grid.Columns.Count > i;)
                    //{
                    //    Grid.Columns.RemoveAt(i);
                    //}
                    XmlNodeList columnNodes = xmlDoc.GetElementsByTagName("Column");
                    foreach (XmlNode columnNode in columnNodes)
                    {
                        string columnName = columnNode.Attributes["Name"].Value;
                        string width = columnNode.Attributes["Width"].Value;
                        string visibleIndex = columnNode.Attributes["VisibleIndex"].Value;

                        Grid.Columns.Add(new GridViewDataTextColumn
                        {
                            FieldName = columnName,
                            Caption = columnName,
                            Width = Unit.Parse(width),
                            Index = int.Parse(visibleIndex)
                        });
                    }
                    List<hazaluser> userList = _userService.GetAllUsers();
                    Grid.DataSource = userList;
                    Grid.DataBind();
                }
                else

                {
                    List<string> columnOrder;
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        var result = resultgetir(_userId, connection);
                        string columnOrderString = (string)result;
                        columnOrder = columnOrderString.Split(',').ToList();
                        foreach (var columnName in columnOrder)
                        {
                            Grid.Columns.Add(new GridViewDataTextColumn
                            {
                                FieldName = columnName,
                                Caption = columnName,
                            });
                        }

                        List<hazaluser> userList = _userService.GetAllUsers();
                        Grid.DataSource = userList;
                        Grid.DataBind();
                    }

                }
            }
            catch (FileNotFoundException)
            {
                List<string> columnOrder = new List<string> { "Id", "email", "password", "username" };

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    var result = resultgetir(_userId, connection);

                    foreach (var columnName in columnOrder)
                    {
                        Grid.Columns.Add(new GridViewDataTextColumn
                        {
                            FieldName = columnName,
                            Caption = columnName,
                        });
                    }

                    List<hazaluser> userList = _userService.GetAllUsers();
                    Grid.DataSource = userList;
                    Grid.DataBind();
                }

            }
        }


        private object resultgetir(int userId, SqlConnection connection)
        {
            connection.Open();
            string query = "SELECT Column1 FROM grid_user WHERE UserId = " + _userId + "";
            SqlCommand command = new SqlCommand(query, connection);
            object result2 = command.ExecuteScalar();
            if (result2 == null || result2 == DBNull.Value)
            {
                query = "SELECT Column1 FROM grid_user WHERE UserId = 0";
                command = new SqlCommand(query, connection);
                result2 = command.ExecuteScalar();
            }

            return result2;
        }


        //protected void btnUpdateUser_Click(object sender, EventArgs e)
        //{
        //    int rowIndex = Grid.FocusedRowIndex;
        //    if (rowIndex < 0)
        //        return;
        //    object id = Grid.GetRowValues(rowIndex, "Id");

        //    string username = editUsername.Text;
        //    string email = editEmail.Text;
        //    string password = editPassword.Text;

        //    int sonuc = _userService.Guncelle(new hazaluser
        //    {
        //        Id = int.Parse(string.Format("{0}", id)),
        //        username = username,
        //        email = email,
        //        password = password
        //    }); ;
        //    if (sonuc > 0)
        //    {
        //        string display = "Kullanıcı Bilgileri Güncellendi";
        //        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);
        //        ClearPopupFields();
        //        BindGrid();
        //        popupGuncelle.ShowOnPageLoad = false;
        //    }
        //}
        private void ClearPopupFields()
        {
            txtUsername.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }


    }
}

