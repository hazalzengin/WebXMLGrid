using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmPurOffervenditemService : ServiceBase 
    {
        private readonly AdmPurOffervenditemRepo _itemRepo;

        public AdmPurOffervenditemService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmPurOffervenditemRepo();
        } 

        public int Add(AdmPurOffervenditem item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmPurOffervenditem item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmPurOffervenditem> GetItemClass(int? Id, int? Offervendref, int? Itemref, string Itemcode, int? Isapprove, string Exp)
        {
            return  _itemRepo.GetItemClass(Id, Offervendref, Itemref, Itemcode, Isapprove, Exp);
        }

        public DataSet GetAll(int? Id, int? Offervendref, int? Itemref, string Itemcode, int? Isapprove)
        {
            return _itemRepo.GetAll(Id, Offervendref, Itemref, Itemcode, Isapprove);
        }

    }
}
