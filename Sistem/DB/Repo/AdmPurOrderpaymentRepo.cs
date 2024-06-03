using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmPurOrderpaymentRepo:BaseRepository<AdmPurOrderpayment> 
    {

        public List<AdmPurOrderpayment> GetItemClass(int? Id, int? Orderref, int? Paymenttype)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PUR_ORDERPAYMENT");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Orderref.HasValue)
                query.Eq("ORDERREF", Orderref.Value);

            if(Paymenttype.HasValue)
                query.Eq("PAYMENTTYPE", Paymenttype.Value);

            return query.ToDataSet().ToFrList<AdmPurOrderpayment>();
        }

        public DataSet GetAll(int? Id, int? Orderref, int? Paymenttype, string LANGU)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_PUR_ORDERPAYMENT");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Orderref.HasValue)
                query.Eq("ORDERREF", Orderref.Value);

            if (Paymenttype.HasValue)
                query.Eq("PAYMENTTYPE", Paymenttype.Value);


            if (!string.IsNullOrWhiteSpace(LANGU))
                query.Eq("LANGU", LANGU);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
