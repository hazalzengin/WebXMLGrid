using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmEdcOfferRepo:BaseRepository<AdmEdcOffer> 
    {

        public List<AdmEdcOffer> GetItemClass(int? Id, int? Creditref, int? LgClcardref, int? Salesmanref, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_EDC_OFFER");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Creditref.HasValue)
                query.Eq("CREDITREF", Creditref.Value);

            if(LgClcardref.HasValue)
                query.Eq("LG_CLCARDREF", LgClcardref.Value);

            if(Salesmanref.HasValue)
                query.Eq("SALESMANREF", Salesmanref.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmEdcOffer>();
        }

        public DataSet GetAll(int? Id, int? Creditref, int? LgClcardref, int? Salesmanref, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_EDC_OFFER");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Creditref.HasValue)
                query.Eq("CREDITREF", Creditref.Value);

            if(LgClcardref.HasValue)
                query.Eq("LG_CLCARDREF", LgClcardref.Value);

            if(Salesmanref.HasValue)
                query.Eq("SALESMANREF", Salesmanref.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
