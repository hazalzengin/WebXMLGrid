using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmEdcOfferPaymentService : ServiceBase 
    {
        private readonly AdmEdcOfferPaymentRepo _itemRepo;

        public AdmEdcOfferPaymentService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmEdcOfferPaymentRepo();
        } 

        public int Add(AdmEdcOfferPayment item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmEdcOfferPayment item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmEdcOfferPayment> GetItemClass(int? Id, int? Offerref)
        {
            return  _itemRepo.GetItemClass(Id, Offerref);
        }

        public DataSet GetAll(int? Id, int? Offerref)
        {
            return _itemRepo.GetAll(Id, Offerref);
        }

    }
}
