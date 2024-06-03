using Sistem.DB.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlGridWebApp
{
    public partial class Login : System.Web.UI.Page
    {
        private readonly hazaluserservice _userService;
        public string ConnectionString = @"Data source=HAZAL;Initial Catalog=hazal;Integrated Security=True";

        public Login()
        {
            _userService = new hazaluserservice(ConnectionString);
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();


            var user = _userService.GetAllUsers().FirstOrDefault(x => x.email == username && x.password == password);
            if (user != null)
            {
                int userId = user.Id;
                Session["User"] = user;
                Response.Redirect($"FrmKullanıcılar.aspx?userId={userId}");
            }
            else
            {
                string display = "E-posta veya şifre yanlış";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);
            }
        }
    }
}
