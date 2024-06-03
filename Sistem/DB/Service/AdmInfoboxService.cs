using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmInfoboxService : ServiceBase 
    {
        private readonly AdmInfoboxRepo _itemRepo;

        public AdmInfoboxService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmInfoboxRepo();
        } 

        public int Add(AdmInfobox item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmInfobox item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmInfobox> GetItemClass(int? Id, int? PageId, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, PageId, Isdel);
        }

        public DataSet GetAll(int? Id, int? PageId, int? Isdel)
        {
            return _itemRepo.GetAll(Id, PageId, Isdel);
        }

    }
}
