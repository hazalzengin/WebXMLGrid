using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmZyhnOfferRepo:BaseRepository<AdmZyhnOffer> 
    {

        public List<AdmZyhnOffer> GetItemClass(int? Id, int? AdmClcardref, int? LgClcardref, int? Isnewclcard, int? Salesmanref, int? status, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ZYHN_OFFER");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(AdmClcardref.HasValue)
                query.Eq("ADM_CLCARDREF", AdmClcardref.Value);

            if(LgClcardref.HasValue)
                query.Eq("LG_CLCARDREF", LgClcardref.Value);

            if(Isnewclcard.HasValue)
                query.Eq("ISNEWCLCARD", Isnewclcard.Value);

            if(Salesmanref.HasValue)
                query.Eq("SALESMANREF", Salesmanref.Value);


            if (status.HasValue)
                query.Eq("STATUS", status.Value);

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmZyhnOffer>();
        }

        public DataSet GetAll(int? status, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_ZYHN_OFFER");


            if (status.HasValue)
                query.Eq("STATUS", status.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);


            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
