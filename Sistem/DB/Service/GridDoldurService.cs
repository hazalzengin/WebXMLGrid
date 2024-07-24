using Sistem.DB.Model;
using Sistem.DB.Repo;
using Sistem.DB.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem.DB.Serviceg
{
    class GridDoldurService : ServiceBase
    {
        private readonly GridDoldurRepo _gridDoldurRepo;
        string connectionString = @"Data source=HAZAL;Initial Catalog=hazal;Integrated Security=True";

        public GridDoldurService(string Constr)
        {
            ProgramConnection.ConStr = Constr;
            _gridDoldurRepo = new GridDoldurRepo();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing == true)
            {
                _gridDoldurRepo.Dispose();
            }
            base.Dispose(disposing);
        }

        public int Ekle(GridDoldur item)
        {

            return _gridDoldurRepo.Insert(item);
        }

        public int Guncelle(GridDoldur item)
        {
            return _gridDoldurRepo.Update(item);
        }

        public int Sil(int id)
        {
            return _gridDoldurRepo.Delete(id);
        }

        public List<GridDoldur> GetAllUsers()
        {
            return _gridDoldurRepo.GetAll();
        }
    }
}
