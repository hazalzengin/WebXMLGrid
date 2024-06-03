using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmEnderOfferitemsService : ServiceBase 
    {
        private readonly AdmEnderOfferitemsRepo _itemRepo;

        public AdmEnderOfferitemsService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmEnderOfferitemsRepo();
        } 

        public int Add(AdmEnderOfferitems item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmEnderOfferitems item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmEnderOfferitems> GetItemClass(int? Id, int? Offerref, int? Itemref, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Offerref, Itemref, Isdel);
        }

        public DataSet GetAll(int? Id, int? Offerref, int? Itemref, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Offerref, Itemref, Isdel);
        }

    }
}
