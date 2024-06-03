using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmErdrOfferitemgroupService : ServiceBase 
    {
        private readonly AdmErdrOfferitemgroupRepo _itemRepo;

        public AdmErdrOfferitemgroupService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmErdrOfferitemgroupRepo();
        } 

        public int Add(AdmErdrOfferitemgroup item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmErdrOfferitemgroup item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmErdrOfferitemgroup> GetItemClass(int? Id, int? Offerref, int? Isactive, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Offerref, Isactive, Isdel);
        }

        public DataSet GetAll(int? Id, int? Offerref, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Offerref, Isactive, Isdel);
        }

    }
}
