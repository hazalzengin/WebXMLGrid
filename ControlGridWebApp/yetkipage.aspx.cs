using DevExpress.Web;
using Sistem.DB.Model;
using Sistem.DB.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlGridWebApp
{
    public partial class yetkipage : System.Web.UI.Page
    {
        public string ConnectionString = @"Data source=HAZAL;Initial Catalog=hazal;Integrated Security=True";
        private readonly hazalmenuservice _menuservice;
        private readonly hazalusermenuservice _usermenuservice;
        private int _userId;

      
        public yetkipage()
        {
            _menuservice = new hazalmenuservice(ConnectionString);
            _usermenuservice = new hazalusermenuservice(ConnectionString);

            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            _userId = int.Parse(Request.QueryString["userId"]);
            if (!IsPostBack)
            {
                
                BindGrid();
            }
        }


  


        private void BindGrid()
        {

            List<hazalusermenu> yetkiliMenus = _usermenuservice.GetYetki(_userId);
            List<int> yetkiliMenuIds = yetkiliMenus.Select(menu => menu.Menuref).ToList();
            List<hazalmenu> menuList = _menuservice.GetDataToClass(null, null, null).ToList();
            GridYetki.DataSource = menuList;
            GridYetki.DataBind();

            for (int rowIndex = 0; rowIndex < GridYetki.VisibleRowCount; rowIndex++)
            {
                int menuId = Convert.ToInt32(GridYetki.GetRowValues(rowIndex, "Id"));
                if (yetkiliMenuIds.Contains(menuId))
                {
                    GridYetki.Selection.SelectRow(rowIndex);
                }
            }
         
       

        }

        
        protected void btnYetkiVer_Click(object sender, EventArgs e)
        {
            var selectedRowKeys = GridYetki.GetSelectedFieldValues("Id");

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM menu_user WHERE userref = @UserId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", _userId);
                var menuReader = command.ExecuteReader();

                foreach (int rowIndex in selectedRowKeys)
                {
                    int menuId = Convert.ToInt32(rowIndex);
                    if (menuReader.Read())
                    {
                        if ((int)menuReader["menuref"]==menuId && (int)menuReader["userref"] == _userId)
                    {
                            int Id = (int)menuReader["id"];
                            hazalusermenu userMenu = new hazalusermenu
                            {
                                Id = Id,
                                Userref = _userId,
                                Menuref = menuId
                            };
                            _usermenuservice.Guncelle(userMenu);

                        }
                        else {
                            hazalusermenu userMenu = new hazalusermenu
                            {

                                Userref = _userId,
                                Menuref = menuId
                            };
                            _usermenuservice.Ekle(userMenu);

                        }
                    }
                   
                    else
                    {
                        hazalusermenu userMenu = new hazalusermenu
                        {

                            Userref = _userId,
                            Menuref = menuId
                        };
                        _usermenuservice.Ekle(userMenu);

                    }

                }
            }
        }
    

            protected void btnYetkiKaldir_Click(object sender, EventArgs e)
        {
            var selectedRowKeys = GridYetki.GetSelectedFieldValues("Id");
            foreach (var key in selectedRowKeys)
            {
                DataTable dataSet = _usermenuservice.GetAll(null, null).Tables[0];
                int menuId = 0;
                if (dataSet.Rows.Count > 0)
                {
                    DataRow row = dataSet.Rows[0];
                     menuId = Convert.ToInt32(row["id"]);
                   
                }
                _usermenuservice.Sil(menuId);
                
            }
            BindGrid();
            string display = "Kullanıcı Yetkisi Kaldırılmıştır";
              
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);

            
        }
    }
}
