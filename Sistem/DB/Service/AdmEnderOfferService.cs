using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmEnderOfferService : ServiceBase 
    {
        private readonly AdmEnderOfferRepo _itemRepo;

        public AdmEnderOfferService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmEnderOfferRepo();
        } 

        public int Add(AdmEnderOffer item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmEnderOffer item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmEnderOffer> GetItemClass(int? Id, int? Status, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Status, Isdel);
        }

        public DataSet GetAll(int? Id, int? Status, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Status, Isdel);
        }

    }
}
