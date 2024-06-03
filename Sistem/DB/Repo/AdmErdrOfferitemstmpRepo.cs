using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmErdrOfferitemstmpRepo:BaseRepository<AdmErdrOfferitemstmp> 
    {

        public List<AdmErdrOfferitemstmp> GetItemClass(int? Id, int? Offerref, int? Itemtype, int? Stockref, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ERDR_OFFERITEMS");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Offerref.HasValue)
                query.Eq("OFFERREF", Offerref.Value);

            if(Itemtype.HasValue)
                query.Eq("ITEMTYPE", Itemtype.Value);

            if(Stockref.HasValue)
                query.Eq("STOCKREF", Stockref.Value);

            if(Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmErdrOfferitemstmp>();
        }

        public DataSet GetAll(int? Id, int? Offerref, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_ERDR_OFFERITEMS");

            if (Offerref.HasValue)
                query.Eq("OFFERREF", Offerref.Value);


            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);


            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
