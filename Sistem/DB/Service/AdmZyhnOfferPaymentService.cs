using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmZyhnOfferPaymentService : ServiceBase 
    {
        private readonly AdmZyhnOfferPaymentRepo _itemRepo;

        public AdmZyhnOfferPaymentService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmZyhnOfferPaymentRepo();
        } 

        public int Add(AdmZyhnOfferPayment item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmZyhnOfferPayment item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmZyhnOfferPayment> GetItemClass(int? Id, int? Offerref, int? Paymenttype)
        {
            return  _itemRepo.GetItemClass(Id, Offerref, Paymenttype);
        }

        public DataSet GetAll(int? Id, int? Offerref, int? Paymenttype, string LANGU)
        {
            return _itemRepo.GetAll(Id, Offerref, Paymenttype, LANGU);
        }

    }
}
