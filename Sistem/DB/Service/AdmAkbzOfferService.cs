using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmAkbzOfferService : ServiceBase
    {
        private readonly AdmAkbzOfferRepo _itemRepo;

        public AdmAkbzOfferService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmAkbzOfferRepo();
        }

        public int Add(AdmAkbzOffer item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmAkbzOffer item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmAkbzOffer> GetItemClass(int? Id, int? LgClcardref, int? Currencytype, int? Paymenttype, int? Status, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetItemClass(Id, LgClcardref, Currencytype, Paymenttype, Status, Isactive, Isdel);
        }

        public DataSet GetAll(int? Status, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetAll(Status, Isactive, Isdel);
        }

    }
}
