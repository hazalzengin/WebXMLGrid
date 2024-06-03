using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmRouheadRepo : BaseRepository<AdmRouhead>
    {

        public List<AdmRouhead> GetItemClass(int? Id, string Code, string Itemcode, int? Warehouse, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ROUHEAD");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (!string.IsNullOrWhiteSpace(Code))
                query.Eq("CODE", Code);

            if (!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if (Warehouse.HasValue)
                query.Eq("WAREHOUSE", Warehouse.Value);

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmRouhead>();
        }

        public DataSet GetAll(string LANGU, string Code, string Itemcode, int? Warehouse, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_ROUHEAD");

            if (!string.IsNullOrWhiteSpace(LANGU))
            {
                query.Eq("LANGU", LANGU);
            }

            if (!string.IsNullOrWhiteSpace(Code))
                query.Eq("CODE", Code);

            if (!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if (Warehouse.HasValue)
                query.Eq("WAREHOUSE", Warehouse.Value);

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);
            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
