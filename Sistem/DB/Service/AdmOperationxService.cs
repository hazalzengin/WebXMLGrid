using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmOperationxService : ServiceBase 
    {
        private readonly AdmOperationxRepo _itemRepo;

        public AdmOperationxService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmOperationxRepo();
        } 

        public int Add(AdmOperationx item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmOperationx item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmOperationx> GetItemClass(int? Id, int? Refid)
        {
            return  _itemRepo.GetItemClass(Id, Refid);
        }

        public DataSet GetAll()
        {
            return _itemRepo.GetAll();
        }

    }
}
