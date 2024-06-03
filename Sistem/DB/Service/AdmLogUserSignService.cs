using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmLogUserSignService : ServiceBase 
    {
        private readonly AdmLogUserSignRepo _itemRepo;

        public AdmLogUserSignService(string ConStr)
        {
            ProgramConnection.ConStr = ConStr;
            _itemRepo = new AdmLogUserSignRepo();
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

        public int Ekle(AdmLogUserSign item)
        {
            return _itemRepo.Insert(item);
        }

        public int Guncelle(AdmLogUserSign item)
        {
            return _itemRepo.Update(item);
        }

        public int Sil(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmLogUserSign> GetItemClass(int id)
        {
            return  _itemRepo.GetItemClass(id);
        }

        public DataSet GetAll()
        {
            return _itemRepo.GetAll();
        }

    }
}
