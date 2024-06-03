using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmPurAuthgroupService : ServiceBase 
    {
        private readonly AdmPurAuthgroupRepo _itemRepo;

        public AdmPurAuthgroupService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmPurAuthgroupRepo();
        } 

        public int Add(AdmPurAuthgroup item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmPurAuthgroup item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmPurAuthgroup> GetItemClass(int? Id, string Groupcode)
        {
            return  _itemRepo.GetItemClass(Id, Groupcode);
        }

        public DataSet GetAll(int? Id, string Groupcode)
        {
            return _itemRepo.GetAll(Id, Groupcode);
        }

    }
}
