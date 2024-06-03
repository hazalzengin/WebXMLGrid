using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmDashsumService : ServiceBase 
    {
        private readonly AdmDashsumRepo _itemRepo;

        public AdmDashsumService(string ConStr)
        {
            ProgramConnection.ConStr = ConStr;
            _itemRepo = new AdmDashsumRepo();
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

        public int Ekle(AdmDashsum item)
        {
            return _itemRepo.Insert(item);
        }

        public int Guncelle(AdmDashsum item)
        {
            return _itemRepo.Update(item);
        }

        public int Sil(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmDashsum> GetItemClass(int id, int active)
        {
            return  _itemRepo.GetItemClass(id, active);
        }


        public List<AdmDashsum> GetAuthItemClass(int id, int userref, int active)
        {
            return _itemRepo.GetAuthItemClass(id, userref, active);
        }

        public DataSet GetAll(int active)
        {
            return _itemRepo.GetAll(active);
        }

    }
}
