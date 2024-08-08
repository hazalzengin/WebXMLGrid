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
using DevExpress.Web.ASPxPivotGrid;

using PivotGridField = DevExpress.Web.ASPxPivotGrid.PivotGridField;

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
            _userId = int.Parse(Request.QueryString["userId"]);
           
            if (!IsPostBack)
            {
                //txtSearchStartdate.Value = DateTime.Now.AddMonths(-1);
                //txtSearchEnddate.Value = DateTime.Now;
                GridDoldur();

            }
            List<hazaluser> userList = _userService.GetAllUsers();
            Grid.DataSource = userList;
            Grid.DataBind();

            PivotGrid.DataSource = Grid.DataSource;
            PivotGrid.RetrieveFields();
        
            if (IsPostBack && Request["__EVENTTARGET"] == "AddColumn")
            {
                string columnName = Request["__EVENTARGUMENT"];
                // AddColumnToGridView(columnName);
                AddFieldToPivotGrid(columnName);
            }

        

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTheme = DropDownList1.SelectedValue;
            //Grid.EnableTheming =true;
            Grid.Theme = selectedTheme;

        }


        private void AddFieldToPivotGrid(string fieldName)
        {
            foreach (PivotGridField field in PivotGrid.Fields)
            {
                if (field.FieldName == fieldName)
                {
                    return;
                }
            }


            DevExpress.XtraPivotGrid.PivotGridField newField = new DevExpress.XtraPivotGrid.PivotGridField();
            newField.FieldName = fieldName;
            newField.Caption = fieldName;
          //  newField.Area = DevExpress.Web.ASPxPivotGrid.DataArea; 
            PivotGrid.Fields.Add(newField);
            //PivotGrid.Fields.Add(fieldName, DevExpress.XtraPivotGrid.PivotArea.RowArea);
            //PivotGrid.Fields.Add(fieldName, DevExpress.XtraPivotGrid.PivotArea.RowArea);
            //PivotGrid.Fields.Add(fieldName, DevExpress.XtraPivotGrid.PivotArea.RowArea);

            PivotGrid.Fields.Add(fieldName, DevExpress.XtraPivotGrid.PivotArea.DataArea);

            List<hazaluser> userList = _userService.GetAllUsers();
            PivotGrid.DataSource = userList;
            PivotGrid.DataBind();
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

        protected void grid_ContextMenuItemVisibility(object sender, ASPxGridViewContextMenuItemVisibilityEventArgs e)
        {
            if (e.MenuType == GridViewContextMenuType.Rows)
            {
                GridViewContextMenuItem itemDuzenle = e.Items.Find(item => item.Name == "Kaydet") as GridViewContextMenuItem;
                
            }
        }

        protected void grid_FillContextMenuItems(object sender, ASPxGridViewContextMenuEventArgs e)
        {
            if (e.MenuType == GridViewContextMenuType.Rows)
            {

                var itemIncele = e.CreateItem("Kaydet", "Kaydet");
                itemIncele.Image.IconID = "actions_apply_16x16"; 
                e.Items.Insert(e.Items.IndexOfCommand(GridViewContextMenuCommand.Refresh), itemIncele);
            }
        }
        protected void grid_ContextMenuItemClick(object sender, ASPxGridViewContextMenuItemClickEventArgs e)
        {
            switch (e.Item.Name)
            {
                case "Kaydet":
                    {
                        var item = Grid.GetDataRow(Grid.FocusedRowIndex);
                        WriteXML();
                        break;
                    }
            }
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
                foreach (GridViewDataColumn column in Grid.Columns)
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
                XmlElement theme = xmlDoc.CreateElement("Theme");
                theme.SetAttribute("Theme", Grid.Theme);
                root.AppendChild(theme);
                xmlDoc.Save(xmlFileName); 
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('XML dosyası başarıyla oluşturuldu.');", true);
                List<hazaluser> userList = _userService.GetAllUsers();
                Grid.DataSource = userList;
                Grid.DataBind();
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
                GridDoldur();

            }
            else
            {
                string display = "Kullanıcı Eklerken hata oluştu";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);
            }


        }



        private void GridDoldur()
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
                    XmlNodeList themes = xmlDoc.GetElementsByTagName("Theme");
                    foreach(XmlNode them in themes)
                    {
                        string theme = them.Attributes["Theme"].Value; 
                        Grid.Theme = theme;
                    }
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
                    columnOrder = new List<string> { "Id", "password", "email" };
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
        private void ClearPopupFields()
        {
            txtUsername.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}

