using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmErdrOfferService : ServiceBase
    {
        private readonly AdmErdrOfferRepo _itemRepo;

        public AdmErdrOfferService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmErdrOfferRepo();
        }

        public int Add(AdmErdrOffer item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmErdrOffer item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmErdrOffer> GetItemClass(int? Id, int? AdmClcardref, int? LgClcardref, int? Isnewclcard, int? Salesmanref, int? status, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetItemClass(Id, AdmClcardref, LgClcardref, Isnewclcard, Salesmanref, status, Isactive, Isdel);
        }

        public DataSet GetAll(int? status, int? Isdel)
        {
            return _itemRepo.GetAll(status, Isdel);
        }

    }
}
