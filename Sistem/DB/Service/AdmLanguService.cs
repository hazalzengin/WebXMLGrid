using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmLanguService : ServiceBase
    {
        private readonly AdmLanguRepo _itemRepo;

        public AdmLanguService(string ConStr)
        {
            ProgramConnection.ConStr = ConStr;
            _itemRepo = new AdmLanguRepo();
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
        public int Ekle(AdmLangu item)
        {
            return _itemRepo.Insert(item);
        }

        public int Guncelle(AdmLangu item)
        {
            return _itemRepo.Update(item);
        }

        public int Sil(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmLangu> GetItemClass(int id, string TABLEN, string REFID, string LANGU)
        {
            return _itemRepo.GetItemClass(id, TABLEN, REFID, LANGU);
        }

        public DataSet GetAll(string TABLEN, string REFID, string LANGU)
        {
            return _itemRepo.GetAll(TABLEN, REFID, LANGU);
        }

    }
}
