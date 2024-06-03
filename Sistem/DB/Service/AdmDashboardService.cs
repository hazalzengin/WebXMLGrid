using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmDashboardService : ServiceBase 
    {
        private readonly AdmDashboardRepo _itemRepo;

        public AdmDashboardService(string ConStr)
        {
            ProgramConnection.ConStr = ConStr;
            _itemRepo = new AdmDashboardRepo();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing == true)
            {
                _itemRepo.Dispose();
                // Managed kaynaklar icin 
            }
            base.Dispose(disposing);
            // UnManaged kaynaklar icin
        }

        public int Ekle(AdmDashboard item)
        {
            return _itemRepo.Insert(item);
        }

        public int Guncelle(AdmDashboard item)
        {
            return _itemRepo.Update(item);
        }

        public int Sil(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmDashboard> GetItemClass(int id, int active)
        {
            return  _itemRepo.GetItemClass(id, active);
        }

        public List<AdmDashboard> GetAuthItemClass(int id, int userref, int active)
        {
            return _itemRepo.GetAuthItemClass(id, userref, active);
        }

        public DataSet GetAll(int active)
        {
            return _itemRepo.GetAll(active);
        }

    }
}
