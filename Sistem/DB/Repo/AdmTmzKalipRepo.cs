using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmTmzKalipRepo : BaseRepository<AdmTmzKalip>
    {

        public List<AdmTmzKalip> GetItemClass(int? Id, int? Itemref, string Itemcode, int? Makineref, string MakineCode, string Ebat, string Cilt, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_TMZ_KALIP");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if (!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if (Makineref.HasValue)
                query.Eq("MAKINEREF", Makineref.Value);

            if (!string.IsNullOrWhiteSpace(MakineCode))
                query.Eq("MAKINE_CODE", MakineCode);

            if (!string.IsNullOrWhiteSpace(Ebat))
                query.Eq("EBAT", Ebat);

            if (!string.IsNullOrWhiteSpace(Cilt))
                query.Eq("CILT", Cilt);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmTmzKalip>();
        }

        public DataSet GetAll(int? Id, int? Itemref, string Itemcode, int? Makineref, string MakineCode, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_TMZ_KALIP");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if (!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if (Makineref.HasValue)
                query.Eq("MAKINEREF", Makineref.Value);

            if (!string.IsNullOrWhiteSpace(MakineCode))
                query.Eq("MAKINE_CODE", MakineCode);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
