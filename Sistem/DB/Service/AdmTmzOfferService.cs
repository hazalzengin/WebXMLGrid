using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmTmzOfferService : ServiceBase 
    {
        private readonly AdmTmzOfferRepo _itemRepo;

        public AdmTmzOfferService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmTmzOfferRepo();
        } 

        public int Add(AdmTmzOffer item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmTmzOffer item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmTmzOffer> GetItemClass(int? Id, int? LgClcardref, int? Status, int? Isdel, int? TransferStatus)
        {
            return  _itemRepo.GetItemClass(Id, LgClcardref, Status, Isdel, TransferStatus);
        }

        public DataSet GetAll(int? Id, int? LgClcardref, int? Status, int? Isdel, int? TransferStatus)
        {
            return _itemRepo.GetAll(Id, LgClcardref, Status, Isdel, TransferStatus);
        }

    }
}
