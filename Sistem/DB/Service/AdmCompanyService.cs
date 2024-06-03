using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmCompanyService : ServiceBase
    {
        private readonly AdmCompanyRepo _itemRepo;

        public AdmCompanyService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmCompanyRepo();
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

        public int Add(AdmCompany item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmCompany item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmCompany> GetItemClass(int? Lref, string Code, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetItemClass(Lref, Code, Isactive, Isdel);
        }

        public DataSet GetAll(int? Lref, string Code, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetAll(Lref, Code, Isactive, Isdel);
        }

    }
}
