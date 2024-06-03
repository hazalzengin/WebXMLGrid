using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmErdrOfferitemsRepo : BaseRepository<AdmErdrOfferitems>
    {

        public List<AdmErdrOfferitems> GetItemClass(int? Id, int? Offerref, int? Groupref, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ERDR_OFFERITEMS");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Offerref.HasValue)
                query.Eq("OFFERREF", Offerref.Value);

            if (Groupref.HasValue)
                query.Eq("GROUPREF", Groupref.Value);

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("GROUPREF", OrderDirection.Asc).ToDataSet().ToFrList<AdmErdrOfferitems>();
        }

        public DataSet GetAll(int? Id, int? Offerref, int? Groupref, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_ERDR_OFFERITEMS");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Offerref.HasValue)
                query.Eq("OFFERREF", Offerref.Value);

            if (Groupref.HasValue)
                query.Eq("GROUPREF", Groupref.Value);

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);


            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
