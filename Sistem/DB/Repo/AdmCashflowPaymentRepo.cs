using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmCashflowPaymentRepo : BaseRepository<AdmCashflowPayment>
    {

        public List<AdmCashflowPayment> GetItemClass(int? Id, int? Ptype, int? Paymenttype, DateTime? Paymentdate, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_CASHFLOW_PAYMENT");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Ptype.HasValue)
                query.Eq("PTYPE", Ptype.Value);

            if (Paymenttype.HasValue)
                query.Eq("PAYMENTTYPE", Paymenttype.Value);

            if (Paymentdate.HasValue)
                query.Eq("PAYMENTDATE", Paymentdate.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmCashflowPayment>();
        }

        public DataSet GetAll(int? Id, int? Ptype, int? Paymenttype, DateTime? Paymentdate, DateTime? Paymentdate2, string LANGU, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_CASHFLOW_PAYMENT");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Ptype.HasValue)
                query.Eq("PTYPE", Ptype.Value);

            if (Paymenttype.HasValue)
                query.Eq("PAYMENTTYPE", Paymenttype.Value);

            if (Paymentdate.HasValue && Paymentdate2.HasValue)
            {
                query.Between("PAYMENTDATE", Paymentdate.Value, Paymentdate2.Value);
            }
            else
            {
                if (Paymentdate.HasValue)
                    query.Eq("PAYMENTDATE", Paymentdate.Value);
            }

            if (!string.IsNullOrWhiteSpace(LANGU))
                query.Eq("LANGU", LANGU);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
