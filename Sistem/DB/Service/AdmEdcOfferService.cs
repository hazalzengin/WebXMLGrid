using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmEdcOfferService : ServiceBase 
    {
        private readonly AdmEdcOfferRepo _itemRepo;

        public AdmEdcOfferService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmEdcOfferRepo();
        } 

        public int Add(AdmEdcOffer item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmEdcOffer item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmEdcOffer> GetItemClass(int? Id, int? Creditref, int? LgClcardref, int? Salesmanref, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Creditref, LgClcardref, Salesmanref, Isdel);
        }

        public DataSet GetAll(int? Id, int? Creditref, int? LgClcardref, int? Salesmanref, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Creditref, LgClcardref, Salesmanref, Isdel);
        }

    }
}
