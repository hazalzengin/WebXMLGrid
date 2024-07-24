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
using System.Configuration;
using System.Web.Script.Services;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Globalization;

namespace ControlGridWebApp
{
    public partial class FrmKullanıcılar : Page
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
            _userId = int.Parse(Request.QueryString["userId"]);

            if (!IsPostBack)
            {
                //txtSearchStartdate.Value = DateTime.Now.AddMonths(-1);
                //txtSearchEnddate.Value = DateTime.Now;
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
            WriteXML();
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('kaydedildi');", true);
            SaveColumnOrder();
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('kaydedildi');", true);
        }

        private void WriteXML()
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlElement root = xmlDoc.CreateElement("Grid");
                xmlDoc.AppendChild(root);
                foreach (GridViewDataColumn column in Grid.VisibleColumns)
                {
                    XmlElement columnNode = xmlDoc.CreateElement("Column");
                    columnNode.SetAttribute("Name", column.FieldName);
                    columnNode.SetAttribute("Caption", column.Caption);
                    columnNode.SetAttribute("UserId",_userId.ToString());
                    columnNode.SetAttribute("Width", column.Width.ToString());
                    columnNode.SetAttribute("VisibleIndex", column.VisibleIndex.ToString());
                    root.AppendChild(columnNode);
                }

                string xmlString = xmlDoc.OuterXml;

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT Id FROM GridDoldur WHERE UserId = @UserId";
                    SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                    selectCommand.Parameters.AddWithValue("@UserId", _userId);
                    int existingId = Convert.ToInt32(selectCommand.ExecuteScalar());

                    if (existingId > 0)
                    {
                        foreach (XmlElement node in root.SelectNodes("Column"))
                        {
                            var colname = node.GetAttribute("Name");
                            var width = node.GetAttribute("Width");
                            var visibleindex = node.GetAttribute("VisibleIndex");
                            string updateQuery = "UPDATE GridDoldur SET ColumnName ='"+colname+"',Width ='"+width+"', VisibleIndex = '"+visibleindex+"' WHERE UserId = " + _userId+"AND Id="+existingId;
                            SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                            updateCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {

                        foreach (XmlElement node in root.SelectNodes("Column"))
                        {
                            string insertQuery = "INSERT INTO GridDoldur (UserId, ColumnName, Width, VisibleIndex) VALUES (@UserId, @ColumnName, @Width, @VisibleIndex)";
                            SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                            insertCommand.Parameters.AddWithValue("@UserId", _userId);
                            insertCommand.Parameters.AddWithValue("@ColumnName", node.GetAttribute("Name"));
                            insertCommand.Parameters.AddWithValue("@Width", node.GetAttribute("Width"));
                            insertCommand.Parameters.AddWithValue("@VisibleIndex", node.GetAttribute("VisibleIndex"));
                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }
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


            //for (int i = 0; i < Grid.Columns.Count; i++)
            //{
            //    if (i!=0)
            //    {
            //        Grid.Columns.RemoveAt(i);

            //    }
            //}
            // List<string> columnOrder = new List<string> { "Id", "email", "password", "username" };

            //foreach (var columnName in columnOrder)
            //{
            //    Grid.Columns.Add(new GridViewDataTextColumn
            //    {
            //        FieldName = columnName,
            //        Caption = columnName,
            //    });
            //}

            List<hazaluser> userList = _userService.GetAllUsers();
            Grid.DataSource = userList;
            Grid.DataBind();


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


            FillGridWithUserColumns();

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
                string sqlQuery = "SELECT * FROM GridDoldur WHERE UserId = @UserId";

                List<GridDoldur> columnConfigs = new List<GridDoldur>();

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@UserId", _userId);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        while (reader.Read())
                        {
                            string columnName = reader["ColumnName"].ToString();
                            string width = reader["Width"].ToString();
                            int visibleIndex = Convert.ToInt32(reader["VisibleIndex"]);
                            columnConfigs.Add(new GridDoldur
                            {
                                ColumnName = columnName,
                                Width = width,
                                VisibleIndex = visibleIndex
                            });
                        }

                        reader.Close();
                        foreach (var config in columnConfigs)
                        {
                            GridViewDataTextColumn gridColumn = new GridViewDataTextColumn
                            {
                                FieldName = config.ColumnName,
                                Caption = config.ColumnName,
                                Width = Unit.Parse(config.Width),
                                VisibleIndex = config.VisibleIndex
                            };

                            Grid.Columns.Add(gridColumn);
                            List<hazaluser> userList = _userService.GetAllUsers();
                            Grid.DataSource = userList;
                            Grid.DataBind();

                        }
                    }

                    else

                    {

                        List<string> columnOrder = new List<string> { "Id", "email", "password", "username" };

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

