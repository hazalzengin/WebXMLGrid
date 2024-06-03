using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmPurOfferitemService : ServiceBase
    {
        private readonly AdmPurOfferitemRepo _itemRepo;

        public AdmPurOfferitemService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmPurOfferitemRepo();
        }

        public int Add(AdmPurOfferitem item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmPurOfferitem item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmPurOfferitem> GetItemClass(int? Id, int? Offerref, int? Demanditemref, string Itemcode, int? Itemref, string Unit)
        {
            return _itemRepo.GetItemClass(Id, Offerref, Demanditemref, Itemcode, Itemref, Unit);
        }

        public DataSet GetAll(int? Id, int? Offerref, int? Demanditemref, int? Itemref)
        {
            return _itemRepo.GetAll(Id, Offerref, Demanditemref, Itemref);
        }

    }
}
