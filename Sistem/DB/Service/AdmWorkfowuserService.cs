using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmWorkfowuserService : ServiceBase 
    {
        private readonly AdmWorkfowuserRepo _itemRepo;

        public AdmWorkfowuserService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmWorkfowuserRepo();
        } 

        public int Add(AdmWorkfowuser item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmWorkfowuser item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmWorkfowuser> GetItemClass(int? Id, int? Isclient, int? Isactive, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Isclient, Isactive, Isdel);
        }

        public DataSet GetAll()
        {
            return _itemRepo.GetAll();
        }

    }
}
