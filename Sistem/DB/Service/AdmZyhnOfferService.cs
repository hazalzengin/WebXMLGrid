using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmZyhnOfferService : ServiceBase
    {
        private readonly AdmZyhnOfferRepo _itemRepo;

        public AdmZyhnOfferService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmZyhnOfferRepo();
        }

        public int Add(AdmZyhnOffer item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmZyhnOffer item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmZyhnOffer> GetItemClass(int? Id, int? AdmClcardref, int? LgClcardref, int? Isnewclcard, int? Salesmanref, int? status, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetItemClass(Id, AdmClcardref, LgClcardref, Isnewclcard, Salesmanref, status, Isactive, Isdel);
        }

        public DataSet GetAll(int? status, int? Isdel)
        {
            return _itemRepo.GetAll(status, Isdel);
        }

    }
}
