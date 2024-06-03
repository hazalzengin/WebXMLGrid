using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmPurOffervendheadService : ServiceBase 
    {
        private readonly AdmPurOffervendheadRepo _itemRepo;

        public AdmPurOffervendheadService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmPurOffervendheadRepo();
        } 

        public int Add(AdmPurOffervendhead item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmPurOffervendhead item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmPurOffervendhead> GetItemClass(int? Id, int? Offerref, int? Firmref, string Firmcode, string Contact, string Mail, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Offerref, Firmref, Firmcode, Contact, Mail, Isdel);
        }

        public DataSet GetAll(int? Id, int? Offerref, int? Firmref, string Firmcode, string Contact, string Mail, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Offerref, Firmref, Firmcode, Contact, Mail, Isdel);
        }

    }
}
