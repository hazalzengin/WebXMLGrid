using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmZyhnOfferPaymentRepo:BaseRepository<AdmZyhnOfferPayment> 
    {

        public List<AdmZyhnOfferPayment> GetItemClass(int? Id, int? Offerref, int? Paymenttype)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ZYHN_OFFER_PAYMENT");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Offerref.HasValue)
                query.Eq("OFFERREF", Offerref.Value);

            if(Paymenttype.HasValue)
                query.Eq("PAYMENTTYPE", Paymenttype.Value);

            return query.ToDataSet().ToFrList<AdmZyhnOfferPayment>();
        }

        public DataSet GetAll(int? Id, int? Offerref, int? Paymenttype, string LANGU)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_ZYHN_OFFER_PAYMENT");

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
