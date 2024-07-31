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

using System.Collections.Generic;
using System.Linq;


namespace ControlGridWebApp
{
    public partial class FrmKullanıcılar : System.Web.UI.Page
    {


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

      
        protected async void Page_Load(object sender, EventArgs e)
        {

          // GridViewFeaturesHelper.SetupGlobalGridViewBehavior(Grid);
            _userId = int.Parse(Request.QueryString["userId"]);
      
            if (!IsPostBack)
            {
                //txtSearchStartdate.Value = DateTime.Now.AddMonths(-1);
                //txtSearchEnddate.Value = DateTime.Now;
                FillGridWithUserColumns();
               
            }

            if (IsPostBack && Request["__EVENTTARGET"] == "AddColumn")
            {
                string columnName = Request["__EVENTARGUMENT"];
                AddColumnToGridView(columnName);
            }
            
        }


        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTheme = DropDownList1.SelectedValue;
            //Grid.EnableTheming =true;
            Grid.Theme = selectedTheme;

        }



        private void AddColumnToGridView(string columnName)
        {
          
            foreach (GridViewColumn column in Grid.Columns)
            {
                if (column is GridViewDataTextColumn textColumn && textColumn.FieldName == columnName)
                {
                    return;
                }
            }
            GridViewDataTextColumn newColumn = new GridViewDataTextColumn();
            newColumn.FieldName = columnName;
            newColumn.Caption = columnName;
            Grid.Columns.Add(newColumn);
            List<hazaluser> userList = _userService.GetAllUsers();
            Grid.DataSource = userList;
            Grid.DataBind();

        }
        protected void gridPopupMenu_ItemClick(object source, DevExpress.Web.MenuItemEventArgs e)
        {
            switch (e.Item.Name)
            {
                case "SaveItem":
                    WriteXML();
                    break;
                case "hidecolumn":
                    HideColumn();
                    break;


            }
        }

        private void HideColumn()
        {
           
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

                    if (column.VisibleIndex > 0)
                    {
                        XmlElement columnNode = xmlDoc.CreateElement("Column");
                        columnNode.SetAttribute("Name", column.FieldName);
                        columnNode.SetAttribute("Visible", column.Visible.ToString());
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
            string filePath = Server.MapPath($"~/GridProperties{_userId}.xml");
           
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", $"alert('Grid özelliklerini silmek istediğinizden emin misiniz?');", true);
            File.Delete(filePath);

            List<hazaluser> userList = _userService.GetAllUsers();
            Grid.DataSource = userList;
            Grid.DataBind();

          

            //ClientScript.RegisterStartupScript(this.GetType(), "alertSuccess", "alert('XML dosyası başarıyla silindi.');", true);


        }


        protected void btnNew_Click(object sender, EventArgs e)
        {
            popupNewUser.ShowOnPageLoad = true;
        }



        protected void btnDelete_Click(object sender, EventArgs e)
        {
            LinkButton btn = sender as LinkButton;
            if (btn != null)
            {
                int id = Convert.ToInt32(btn.CommandArgument);
                _userService.Sil(id);
            }


          //  FillGridWithUserColumns();

        }
        protected void btnYetki_Click(object sender, EventArgs e)
        {
            string userId = ((LinkButton)sender).CommandArgument;
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
                FillGridWithUserColumns();

            }
            else
            {
                string display = "Kullanıcı Eklerken hata oluştu";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);
            }


        }
        //private void UpdateColumnOrder()
        //{
        //    _columnOrder = Grid.VisibleColumns.OfType<GridViewDataColumn>()
        //                                   .OrderBy(column => column.VisibleIndex)
        //                                   .Select(column => column.FieldName)
        //                                   .ToList();
        //}


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
                    updateCommand.Parameters.AddWithValue("@Column1", string.Join(",", _columnOrder.Skip(1)));
                    updateCommand.ExecuteNonQuery();
                }
                else
                {
                    string query2 = "INSERT INTO grid_user (UserId, Column1) VALUES (@UserId, @Column1)";
                    SqlCommand command2 = new SqlCommand(query2, connection);
                    command2.Parameters.AddWithValue("@UserId", _userId);
                    command2.Parameters.AddWithValue("@Column1", string.Join(",", _columnOrder.Skip(1)));
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
                List<string> columnOrder;
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string xmlFilePath = Server.MapPath($"~/GridProperties{_userId}.xml");
                    if (File.Exists(xmlFilePath))
                    {
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.Load(xmlFilePath);

                      
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
                        columnOrder = new List<string> {"Id","password","email"};
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
                List<string> columnOrder = new List<string> { };

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    

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

