using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmEdcOfferitemsService : ServiceBase 
    {
        private readonly AdmEdcOfferitemsRepo _itemRepo;

        public AdmEdcOfferitemsService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmEdcOfferitemsRepo();
        } 

        public int Add(AdmEdcOfferitems item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmEdcOfferitems item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmEdcOfferitems> GetItemClass(int? Id, int? Offerref, int? Itemref, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Offerref, Itemref, Isdel);
        }

        public DataSet GetAll(int? Id, int? Offerref, int? Itemref, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Offerref, Itemref, Isdel);
        }

    }
}
