using Sistem.DB.Model;
using Sistem.DB.Repo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem.DB.Service
{

    public class hazaluserservice : ServiceBase
    {
        private readonly hazaluserrepo _userrepo;
        string connectionString = @"Data source=HAZAL;Initial Catalog=hazal;Integrated Security=True";
        public hazaluserservice(string Constr)
        {
            ProgramConnection.ConStr = Constr;
            _userrepo = new hazaluserrepo();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing == true)
            {
                _userrepo.Dispose();
            }
            base.Dispose(disposing);
        }

        public int Ekle(hazaluser item)
        {

            return _userrepo.Insert(item);
        }

        public int Guncelle(hazaluser item)
        {
            return _userrepo.Update(item);
        }

        public int Sil(int id)
        {
            return _userrepo.Delete(id);
        }

        public List<hazaluser> GetAllUsers()
        {
            return _userrepo.GetAll();
        }

        public DataSet GetAllUsers2(int? id, String kullanici, String sifre)
        {
            return _userrepo.GetAll2(id, kullanici, sifre);
        }
        public string GetUserPassword(int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT password FROM users WHERE Id = @userId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString();
                    }
                }
            }
            return null;
        }



    }
}
