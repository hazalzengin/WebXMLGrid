using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmBomheadRepo : BaseRepository<AdmBomhead>
    {

        public List<AdmBomhead> GetItemClass(int? Id, string itemcode, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_BOMHEAD");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);


            if (!string.IsNullOrWhiteSpace(itemcode))
            {
                query.Eq("ITEMCODE", itemcode);
            }

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmBomhead>();
        }
        public List<AdmBomhead> GetItemClass(int? Id, string itemcode, int? Isactive, int? Isdel,int? bomtype,int? alternativeno)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_BOMHEAD");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);


            if (!string.IsNullOrWhiteSpace(itemcode))
            {
                query.Eq("ITEMCODE", itemcode);
            }

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            if (bomtype.HasValue)
                query.Eq("BOMTYPE", bomtype.Value);

            if (alternativeno.HasValue)
                query.Eq("ALTERNATIVENO", alternativeno.Value);

            return query.ToDataSet().ToFrList<AdmBomhead>();
        }
        public DataSet GetAll(string LANGU, string itemcode, int? Id, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_BOMHEAD");


            if (!string.IsNullOrWhiteSpace(LANGU))
            {
                query.Eq("LANGU", LANGU);
            }

            if (!string.IsNullOrWhiteSpace(itemcode))
            {
                query.Eq("ITEMCODE", itemcode);
            }

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
