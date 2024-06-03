using Sistem.DB.Model;
using Sistem.DB.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem.DB.Service
{
    public class hazalmenuservice : ServiceBase
    {
        private readonly hazalmenurepo _menurepo;
        string connectionString = @"Data source=HAZAL;Initial Catalog=hazal;Integrated Security=True";

        public hazalmenuservice(string ConStr)
        {
            ProgramConnection.ConStr = ConStr;
            _menurepo = new hazalmenurepo();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing == true)
            {
                _menurepo.Dispose();
            }
            base.Dispose(disposing);
        }

        public int Ekle(hazalmenu item)
        {
            return _menurepo.Insert(item);
        }

        public int Guncelle(hazalmenu item)
        {
            return _menurepo.Update(item);
        }

        public int Sil(int id)
        {
            return _menurepo.Delete(id);
        }

        public List<hazalmenu> GetItemClass(int id)
        {
            return _menurepo.GetItemClass(id);
        }

        public List<hazalmenu> GetDataToClass(int? id, String code, String menu)
        {
            return _menurepo.GetDataToClass(id, code, menu);
        }


    }
}
