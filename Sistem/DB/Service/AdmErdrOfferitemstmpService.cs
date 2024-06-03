using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmErdrOfferitemstmpService : ServiceBase 
    {
        private readonly AdmErdrOfferitemstmpRepo _itemRepo;

        public AdmErdrOfferitemstmpService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmErdrOfferitemstmpRepo();
        } 

        public int Add(AdmErdrOfferitemstmp item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmErdrOfferitemstmp item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmErdrOfferitemstmp> GetItemClass(int? Id, int? Offerref, int? Itemtype, int? Stockref, int? Isactive, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Offerref, Itemtype, Stockref, Isactive, Isdel);
        }

        public DataSet GetAll(int? Id, int? Offerref, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetAll(Id,  Offerref, Isactive,  Isdel);
        }

    }
}
