using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmAkbzOfferitemsService : ServiceBase
    {
        private readonly AdmAkbzOfferitemsRepo _itemRepo;

        public AdmAkbzOfferitemsService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmAkbzOfferitemsRepo();
        }

        public int Add(AdmAkbzOfferitems item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmAkbzOfferitems item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmAkbzOfferitems> GetItemClass(int? Id, int? Offerref, int? Itemkref, int? Amount, int? Unit, int? Vat, int? Vattype, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetItemClass(Id, Offerref, Itemkref, Amount, Unit, Vat, Vattype, Isactive, Isdel);
        }

        public DataSet GetAll(int? Offerref,int? Isactive, int? Isdel)
        {
            return _itemRepo.GetAll( Offerref,Isactive, Isdel);
        }

    }
}
