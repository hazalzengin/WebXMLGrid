using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmLogService : ServiceBase 
    {
        private readonly AdmLogRepo _itemRepo;

        public AdmLogService(string ConStr)
        {
            ProgramConnection.ConStr = ConStr;
            _itemRepo = new AdmLogRepo();
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

        public int Ekle(AdmLog item)
        {
            return _itemRepo.Insert(item);
        }

        public int Guncelle(AdmLog item)
        {
            return _itemRepo.Update(item);
        }

        public int Sil(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmLog> GetItemClass(int id)
        {
            return  _itemRepo.GetItemClass(id);
        }

        public DataSet GetAll()
        {
            return _itemRepo.GetAll();
        }

    }
}
