using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmEdcOfferPaymentRepo:BaseRepository<AdmEdcOfferPayment> 
    {

        public List<AdmEdcOfferPayment> GetItemClass(int? Id, int? Offerref)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_EDC_OFFER_PAYMENT");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Offerref.HasValue)
                query.Eq("OFFERREF", Offerref.Value);

            return query.ToDataSet().ToFrList<AdmEdcOfferPayment>();
        }

        public DataSet GetAll(int? Id, int? Offerref)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_EDC_OFFER_PAYMENT");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Offerref.HasValue)
                query.Eq("OFFERREF", Offerref.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
