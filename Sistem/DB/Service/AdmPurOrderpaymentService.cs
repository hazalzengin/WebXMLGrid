using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmPurOrderpaymentService : ServiceBase 
    {
        private readonly AdmPurOrderpaymentRepo _itemRepo;

        public AdmPurOrderpaymentService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmPurOrderpaymentRepo();
        } 

        public int Add(AdmPurOrderpayment item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmPurOrderpayment item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmPurOrderpayment> GetItemClass(int? Id, int? Orderref, int? Paymenttype)
        {
            return  _itemRepo.GetItemClass(Id, Orderref, Paymenttype);
        }

        public DataSet GetAll(int? Id, int? Orderref, int? Paymenttype, string LANGU)
        {
            return _itemRepo.GetAll(Id, Orderref, Paymenttype, LANGU);
        }

    }
}
