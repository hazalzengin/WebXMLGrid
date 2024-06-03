using System;
using Sistem.DB.Model;
using Sistem.DB.Service;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace ControlGridWebApp
{
    public partial class popuppage : System.Web.UI.Page
    {
        private hazaluserservice _userService;
        public string ConnectionString = @"Data Source=HAZAL;Initial Catalog=hazal;Integrated Security=True";
        public int _userId;
        public string _username;
        public string _password;
        public string _email;

        protected void Page_Load(object sender, EventArgs e)
        {
            _userService = new hazaluserservice(ConnectionString);
            _userId = int.Parse(Request.QueryString["userId"]);
            if (!IsPostBack)
            {
              
                FillUserData();
                popupGuncelle.ShowOnPageLoad = true;
            }
        }

        public int KullaniciGuncelle(int userId)
        {
            return userId;
        }

        private void FillUserData()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Users WHERE Id = @UserId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserId", _userId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    _username = reader["username"].ToString();
                    _email = reader["email"].ToString();
                    _password = reader["password"].ToString();

                    editUsername.Text = _username;
                    editEmail.Text = _email;
                    editPassword.Text = _password;
                }
                con.Close();
            }
        }

        protected void btnUpdateUser_Click(object sender, EventArgs e)
        {
            string username = editUsername.Text;
            string email = editEmail.Text;
            string password = editPassword.Text;
            int sonuc = _userService.Guncelle(new hazaluser
            {
                Id= _userId,
                username = username,
                email = email,
                password = password
            });
            string display = sonuc > 0 ? "Kullanıcı Bilgileri Güncellendi" : "Kullanıcı Eklerken hata oluştu";
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);

            Response.Redirect("FrmKullanıcılar.aspx?userId=" + _userId);
        }
    }
}
