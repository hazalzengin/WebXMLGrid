using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmPurOffervenditemRepo : BaseRepository<AdmPurOffervenditem>
    {

        public List<AdmPurOffervenditem> GetItemClass(int? Id, int? Offervendref, int? Itemref, string Itemcode, int? Isapprove, string Exp)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PUR_OFFERVENDITEM");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Offervendref.HasValue)
                query.Eq("OFFERVENDREF", Offervendref.Value);

            if (Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if (!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if (Isapprove.HasValue)
                query.Eq("ISAPPROVE", Isapprove.Value);

            if (!string.IsNullOrWhiteSpace(Exp))
                query.Eq("EXP", Exp);

            return query.ToDataSet().ToFrList<AdmPurOffervenditem>();
        }

        public DataSet GetAll(int? Id, int? Offervendref, int? Itemref, string Itemcode, int? Isapprove)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_PUR_OFFERVENDITEM");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Offervendref.HasValue)
                query.Eq("OFFERVENDREF", Offervendref.Value);

            if (Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if (!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if (Isapprove.HasValue)
                query.Eq("ISAPPROVE", Isapprove.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
