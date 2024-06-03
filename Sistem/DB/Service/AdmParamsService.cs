using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmParamsService : ServiceBase
    {
        private readonly AdmParamsRepo _itemRepo;

        public AdmParamsService(string ConStr)
        {
            ProgramConnection.ConStr = ConStr;
            _itemRepo = new AdmParamsRepo();
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

        public int Ekle(AdmParams item)
        {
            return _itemRepo.Insert(item);
        }

        public int Guncelle(AdmParams item)
        {
            return _itemRepo.Update(item);
        }

        public int Sil(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmParams> GetItemClass(int id, string PTYPE, string PCODE, int isDel)
        {
            return _itemRepo.GetItemClass(id, PTYPE,PCODE, isDel);
        }

        public DataSet GetAll(int id, string LANGU, string PTYPE, string PCODE, int isActive, int isDel)
        {
            return _itemRepo.GetAll(id, LANGU, PTYPE, PCODE, isActive, isDel);
        }

    }
}
