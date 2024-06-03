using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmCashflowPaymentService : ServiceBase
    {
        private readonly AdmCashflowPaymentRepo _itemRepo;

        public AdmCashflowPaymentService(string conStr = "")
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmCashflowPaymentRepo();
        }

        public int Add(AdmCashflowPayment item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmCashflowPayment item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmCashflowPayment> GetItemClass(int? Id, int? Ptype, int? Paymenttype, DateTime? Paymentdate, int? Isdel)
        {
            return _itemRepo.GetItemClass(Id, Ptype, Paymenttype, Paymentdate, Isdel);
        }

        public DataSet GetAll(int? Id, int? Ptype, int? Paymenttype, DateTime? Paymentdate, DateTime? Paymentdate2, string LANGU, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Ptype, Paymenttype, Paymentdate, Paymentdate2, LANGU, Isdel);
        }

    }
}
