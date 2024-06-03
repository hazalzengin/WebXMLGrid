using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmParamsxService : ServiceBase 
    {
        private readonly AdmParamsxRepo _itemRepo;

        public AdmParamsxService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmParamsxRepo();
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

        public int Add(AdmParamsx item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmParamsx item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmParamsx> GetItemClass(int? Id, int? Refid)
        {
            return  _itemRepo.GetItemClass(Id, Refid);
        }

        public DataSet GetAll()
        {
            return _itemRepo.GetAll();
        }

    }
}
