using Sistem.DB.Model;
using Sistem.DB.Repo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem.DB.Service
{
    public class eventsservice : ServiceBase
    {
        private readonly eventsrepo _userrepo;
        string connectionString = @"Data source=HAZAL;Initial Catalog=hazal;Integrated Security=True";
        public eventsservice(string Constr)
        {
            ProgramConnection.ConStr = Constr;
            _userrepo = new eventsrepo();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing == true)
            {
                _userrepo.Dispose();
            }
            base.Dispose(disposing);
        }

        public int Ekle(events item)
        {

            return _userrepo.Insert(item);
        }

        public int Guncelle(events item)
        {
            return _userrepo.Update(item);
        }

        public int Sil(int id)
        {
            return _userrepo.Delete(id);
        }

        public List<events> GetAllUsers()
        {
            return _userrepo.GetAll();
        }

     
        public string Getevents(DateTime startdate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT password FROM users WHERE Id = @startdate";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@startdate", startdate);
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