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

namespace ControlGridWebApp
{
    public partial class FrmKullanıcılar : Page
    {
        private readonly hazaluserservice _userService;
        public string ConnectionString = @"Data source=HAZAL;Initial Catalog=hazal;Integrated Security=True";
        public int _userId;
        private List<string> _columnOrder;
        public FrmKullanıcılar()
        {

            _userService = new hazaluserservice(ConnectionString);

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            _userId = int.Parse(Request.QueryString["userId"]);

            Page.ClientScript.RegisterStartupScript(GetType(), "AddColumnToGrid", "function AddColumnToGrid(columnName) { var gridView = $('#Grid').dxDataGrid('instance'); gridView.addColumn(columnName); }", true);

            if (!IsPostBack)
            {
                FillGridWithUserColumns();
            }



        }


        protected void BindGrid()
        {
            Grid.DataSource = _userService.GetAllUsers();
            Grid.DataBind();
        }

        protected void gridPopupMenu_ItemClick(object source, DevExpress.Web.MenuItemEventArgs e)
        {
            switch (e.Item.Name)
            {
                case "SaveItem":
                    SaveGridPropertiesAsXml();
                    break;

                case "RemoveColumn":
                    RemoveColumn();
                    break;

            }
        }
        [WebMethod]
        public static string UpdateGridView(string[] columns)
        {
            GridView gridView = new GridView();
            gridView.AutoGenerateColumns = false;

            foreach (string columnName in columns)
            {
                BoundField column = new BoundField();
                column.DataField = columnName;
                column.HeaderText = columnName;
                gridView.Columns.Add(column);
            }


            StringWriter stringWriter = new StringWriter();
            HtmlTextWriter htmlWriter = new HtmlTextWriter(stringWriter);
            gridView.RenderControl(htmlWriter);

            return stringWriter.ToString();
        }


        private void RemoveColumn()
        {

            var column = Grid.VisibleColumns[2];
            
                if (column != null)
                {
                    column.Visible = false;

                    List<hazaluser> userList = _userService.GetAllUsers();
                    Grid.DataSource = userList;
                    Grid.DataBind();
                }
                else
                {
                    // Handle the case when the column is not found
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

                foreach (GridViewDataColumn column in Grid.Columns)
                {
                    XmlElement columnNode = xmlDoc.CreateElement("Column");
                    columnNode.SetAttribute("Name", column.FieldName);
                    columnNode.SetAttribute("Caption", column.Caption);
                    columnNode.SetAttribute("Width", column.Width.ToString());
                    root.AppendChild(columnNode);
                }

                xmlDoc.Save(xmlFileName);

                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('XML dosyası başarıyla oluşturuldu.');", true);
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('XML dosyası oluşturulurken hata oluştu: " + ex.Message + "');", true);
            }
        }



        protected void Grid_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {

            BindGrid();
        }
             protected void btnGuncellePage_Click(object sender, EventArgs e)
        {
            string userId = ((DevExpress.Web.ASPxButton)sender).CommandArgument;
            Response.Redirect("popuppage.aspx?userId=" + userId);

        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            ASPxButton btnDelete = sender as ASPxButton;
            int userId = Convert.ToInt32(btnDelete.CommandArgument);
            _userService.Sil(userId);
            BindGrid();
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
            BindGrid();

        }
        private void UpdateColumnOrder()
        {
            _columnOrder = Grid.VisibleColumns.OfType<GridViewDataColumn>()
                                           .OrderBy(column => column.VisibleIndex)
                                           .Select(column => column.FieldName)
                                           .ToList();
        }

        [WebMethod]
        public static string AddColumnToGrid(string columnName)
        {
            var gridView = new ASPxGridView();

            var newColumn = new GridViewDataTextColumn
            {
                FieldName = columnName,
                Caption = columnName,
                VisibleIndex = gridView.Columns.Count
            };
            gridView.Columns.Add(newColumn);

            gridView.DataSource = YourDataSource; 
            gridView.DataBind();
            using (StringWriter stringWriter = new StringWriter())
            {
                using (HtmlTextWriter htmlWriter = new HtmlTextWriter(stringWriter))
                {
                    gridView.RenderControl(htmlWriter);
                    return stringWriter.ToString();
                }
            }
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
                if (result != null && result != DBNull.Value)
                {
                    string updateQuery = "UPDATE grid_user SET Column1 = @Column1 WHERE UserId = @UserId";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@UserId", _userId);
                    updateCommand.Parameters.AddWithValue("@Column1", string.Join(",", _columnOrder.Skip(4)));
                    //updateCommand.Parameters.AddWithValue("@Column1", string.Join(",", _columnOrder));
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
                
            }

        }


        private void FillGridWithUserColumns()
        {
            try
            {
                List<string> columnOrder;
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    var result = resultgetir(_userId, connection);

                    if (result != null && result != DBNull.Value)
                    {
                        string columnOrderString = (string)result;
                        columnOrder = columnOrderString.Split(',').ToList();
                    }
                    else
                    {
                        // Handle if there are no saved column orders
                        columnOrder = GetDefaultColumnOrder(); // Assuming this method gets the default column order
                    }
                }

                int index = 5;
                foreach (string columnName in columnOrder)
                {
                    string width = GetColumnWidthFromXML(columnName);

                    if (string.IsNullOrEmpty(width))
                    {
                        List<hazaluser> userList2 = _userService.GetAllUsers();
                        Grid.DataSource = userList2;
                        Grid.DataBind();
                    }
                    else
                    {
                        Grid.Columns[columnName].Width = Unit.Parse(width);
                        GridViewDataTextColumn column = new GridViewDataTextColumn
                        {
                            FieldName = columnName,
                            Caption = columnName
                        };
                       // Grid.Columns.Add(column);
                        Grid.Columns[columnName].VisibleIndex = index;
                        index++;
                        List<hazaluser> userList = _userService.GetAllUsers();
                        Grid.DataSource = userList;
                        Grid.DataBind();
                    }

                    
                }

               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: " + ex.Message);
            }
        }

        private string GetColumnWidthFromXML(string columnName)
        {
            try
            {
                string xmlFilePath = Server.MapPath($"~/GridProperties{_userId}.xml");
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlFilePath);

                XmlNodeList columnNodes = xmlDoc.GetElementsByTagName("Column");
                foreach (XmlNode columnNode in columnNodes)
                {
                    if (columnNode.Attributes["Name"].Value == columnName)
                    {
                        return columnNode.Attributes["Width"].Value;
                    }
                }
            }
            catch (FileNotFoundException)
            {
                
                Console.WriteLine("XML dosyası bulunamadı.");
            }
            catch (Exception ex)
            {
               
                Console.WriteLine("XML dosyası okurken hata verdi: " + ex.Message);
            }

            return null;
        }

        private List<string> GetDefaultColumnOrder()
        {
            // Define your default column order here
            return new List<string> { "Column1", "Column2", "Column3" };
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

