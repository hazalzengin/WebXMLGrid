using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmEnderPricelistItemsRepo:BaseRepository<AdmEnderPricelistItems> 
    {

        public List<AdmEnderPricelistItems> GetItemClass(int? Id, int? Parentref, int? Itemref)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ENDER_PRICELIST_ITEMS");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Parentref.HasValue)
                query.Eq("PARENTREF", Parentref.Value);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            return query.ToDataSet().ToFrList<AdmEnderPricelistItems>();
        }

        public DataSet GetAll(int? Id, int? Parentref, int? Itemref)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ENDER_PRICELIST_ITEMS");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Parentref.HasValue)
                query.Eq("PARENTREF", Parentref.Value);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
