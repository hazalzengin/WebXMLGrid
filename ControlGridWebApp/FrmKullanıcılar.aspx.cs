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
                txtSearchStartdate.Value = DateTime.Now.AddMonths(-1);
                txtSearchEnddate.Value = DateTime.Now;
                FillGridWithUserColumns();
            }
            if (Request["__EVENTTARGET"] == "AddColumn")
            {
                string columnName = Request["__EVENTARGUMENT"];
                AddColumnToGridView(columnName);
            }

            GridDoldur();

        }
        protected async  void FilterChanged(object sender, EventArgs e)
        {
              GridDoldur();
        }

        public async void GridDoldur()
        {
            try
            {
                string startdate = DateTime.Parse(txtSearchStartdate.Value + " ").ToString("yyyy-MM-dd");
                string enddate = DateTime.Parse(txtSearchEnddate.Value + " ").ToString("yyyy-MM-dd");
                //string startdate = "2024-06-01";
                //string enddate = "2024-09-07";


                using (var httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync(apiUrl + queryParams);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(json);

                        GridFatura.DataSource = dataTable;
                        GridFatura.DataBind();
                    }
                    else
                    {
                        Response.Write("API isteği başarısız: " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("Hata oluştu: " + ex.Message);
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
                    if (column.VisibleIndex > 0)
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
            //List<string> columnOrder = new List<string> { "Id", "email", "password", "username" };
            //for (int i = Grid.Columns.Count - 1; i > 0; i--)
            //{
            //    Grid.Columns.RemoveAt(i);
            //}

            //foreach (var columnName in columnOrder)
            //{
            //    GridViewDataTextColumn newColumn = new GridViewDataTextColumn();
            //    newColumn.FieldName = columnName;
            //    newColumn.Caption = columnName;
            //    Grid.Columns.Add(newColumn);
            //}
            //List<hazaluser> userList = _userService.GetAllUsers();
            //Grid.DataSource = userList;
            //Grid.DataBind();
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

                    List<string> columnOrder = new List<string> { "Id", "email", "password", "username" };

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

