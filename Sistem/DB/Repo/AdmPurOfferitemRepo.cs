using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmPurOfferitemRepo : BaseRepository<AdmPurOfferitem>
    {

        public List<AdmPurOfferitem> GetItemClass(int? Id, int? Offerref, int? Demanditemref, string Itemcode, int? Itemref, string Unit)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PUR_OFFERITEM");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Offerref.HasValue)
                query.Eq("OFFERREF", Offerref.Value);

            if (Demanditemref.HasValue)
                query.Eq("DEMANDITEMREF", Demanditemref.Value);

            if (Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if (!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if (!string.IsNullOrWhiteSpace(Unit))
                query.Eq("UNIT", Unit);

            return query.ToDataSet().ToFrList<AdmPurOfferitem>();
        }

        public DataSet GetAll(int? Id, int? Offerref, int? Demanditemref, int? Itemref)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PUR_OFFERITEM");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Offerref.HasValue)
                query.Eq("OFFERREF", Offerref.Value);

            if (Demanditemref.HasValue)
                query.Eq("DEMANDITEMREF", Demanditemref.Value);

            if (Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
