using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmItemAccSupplierRepo:BaseRepository<AdmItemAccSupplier> 
    {

        public List<AdmItemAccSupplier> GetItemClass(int? Id, int? Itemref, string Itemcode, int? Firmref, string Firmcode, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ITEM_ACC_SUPPLIER");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if(!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if(Firmref.HasValue)
                query.Eq("FIRMREF", Firmref.Value);

            if(!string.IsNullOrWhiteSpace(Firmcode))
                query.Eq("FIRMCODE", Firmcode);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmItemAccSupplier>();
        }

        public DataSet GetAll(int? Id, int? Itemref, string Itemcode, int? Firmref, string Firmcode, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ITEM_ACC_SUPPLIER");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if (!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if (Firmref.HasValue)
                query.Eq("FIRMREF", Firmref.Value);

            if (!string.IsNullOrWhiteSpace(Firmcode))
                query.Eq("FIRMCODE", Firmcode);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
