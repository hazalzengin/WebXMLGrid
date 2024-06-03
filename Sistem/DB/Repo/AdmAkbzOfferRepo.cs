using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmAkbzOfferRepo:BaseRepository<AdmAkbzOffer> 
    {

        public List<AdmAkbzOffer> GetItemClass(int? Id, int? LgClcardref, int? Currencytype, int? Paymenttype, int? Status, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_AKBZ_OFFER");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(LgClcardref.HasValue)
                query.Eq("LG_CLCARDREF", LgClcardref.Value);

            if(Currencytype.HasValue)
                query.Eq("CURRENCYTYPE", Currencytype.Value);

            if(Paymenttype.HasValue)
                query.Eq("PAYMENTTYPE", Paymenttype.Value);

            if(Status.HasValue)
                query.Eq("STATUS", Status.Value);

            if(Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmAkbzOffer>();
        }

        public DataSet GetAll(int? Status, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_AKBZ_OFFER");

            if (Status.HasValue)
                query.Eq("STATUS", Status.Value);

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
