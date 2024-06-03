using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmRouitemRepo : BaseRepository<AdmRouitem>
    {

        public List<AdmRouitem> GetItemClass(int? Id, string Roucode, string Oprcode, int? Itemref, string Itemcode, int? Warehouse, int? ItemType, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ROUITEM");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (!string.IsNullOrWhiteSpace(Roucode))
                query.Eq("ROUCODE", Roucode);

            if (!string.IsNullOrWhiteSpace(Oprcode))
                query.Eq("OPRCODE", Oprcode);

            if (Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if (!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if (Warehouse.HasValue)
                query.Eq("WAREHOUSE", Warehouse.Value);

            if (ItemType.HasValue)
                query.Eq("ITEMTYPE", ItemType.Value);

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmRouitem>();
        }

        public DataSet GetAll(int? Id, string Roucode, string Oprcode, int? Itemref, string Itemcode, int? Warehouse, int? ItemType, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_ROUITEM");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (!string.IsNullOrWhiteSpace(Roucode))
                query.Eq("ROUCODE", Roucode);

            if (!string.IsNullOrWhiteSpace(Oprcode))
                query.Eq("OPRCODE", Oprcode);

            if (Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if (!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if (Warehouse.HasValue)
                query.Eq("WAREHOUSE", Warehouse.Value);

            if (ItemType.HasValue)
                query.Eq("ITEMTYPE", ItemType.Value);

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);


            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
