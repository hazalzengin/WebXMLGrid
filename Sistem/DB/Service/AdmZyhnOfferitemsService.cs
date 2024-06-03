using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmZyhnOfferitemsService : ServiceBase
    {
        private readonly AdmZyhnOfferitemsRepo _itemRepo;

        public AdmZyhnOfferitemsService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmZyhnOfferitemsRepo();
        }

        public int Add(AdmZyhnOfferitems item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmZyhnOfferitems item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmZyhnOfferitems> GetItemClass(int? Id, int? Offerref, int? Groupref, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetItemClass(Id, Offerref, Groupref, Isactive, Isdel);
        }

        public DataSet GetAll(int? Id, int? Offerref, int? Groupref, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Offerref, Groupref, Isactive, Isdel);
        }

    }
}
