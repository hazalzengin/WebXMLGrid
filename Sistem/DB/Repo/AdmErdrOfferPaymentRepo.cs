using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmErdrOfferPaymentRepo:BaseRepository<AdmErdrOfferPayment> 
    {

        public List<AdmErdrOfferPayment> GetItemClass(int? Id, int? Offerref, int? Paymenttype)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ERDR_OFFER_PAYMENT");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Offerref.HasValue)
                query.Eq("OFFERREF", Offerref.Value);

            if(Paymenttype.HasValue)
                query.Eq("PAYMENTTYPE", Paymenttype.Value);

            return query.ToDataSet().ToFrList<AdmErdrOfferPayment>();
        }

        public DataSet GetAll(int? Id, int? Offerref, int? Paymenttype, string LANGU)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_ERDR_OFFER_PAYMENT");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Offerref.HasValue)
                query.Eq("OFFERREF", Offerref.Value);

            if (Paymenttype.HasValue)
                query.Eq("PAYMENTTYPE", Paymenttype.Value);

            if (!string.IsNullOrWhiteSpace(LANGU))
                query.Eq("LANGU", LANGU);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
