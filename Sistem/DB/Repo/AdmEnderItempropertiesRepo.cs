using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmEnderItempropertiesRepo : BaseRepository<AdmEnderItemproperties>
    {

        public List<AdmEnderItemproperties> GetItemClass(int? Id, string EskiKod, string ErpKodu, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ENDER_ITEMPROPERTIES");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (!string.IsNullOrWhiteSpace(EskiKod))
                query.Eq("ESKI_KOD", EskiKod);

            if (!string.IsNullOrWhiteSpace(ErpKodu))
                query.Eq("ERP_KODU", ErpKodu);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmEnderItemproperties>();
        }

        public DataSet GetAll(int? Id, string EskiKod, string ErpKodu, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ENDER_ITEMPROPERTIES");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (!string.IsNullOrWhiteSpace(EskiKod))
                query.Eq("ESKI_KOD", EskiKod);

            if (!string.IsNullOrWhiteSpace(ErpKodu))
                query.Eq("ERP_KODU", ErpKodu);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
