using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmProdFpUsagefichelineRepo:BaseRepository<AdmProdFpUsageficheline> 
    {

        public List<AdmProdFpUsageficheline> GetItemClass(int? Id, int? Ficheref, int? Itemref, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PROD_FP_USAGEFICHELINE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Ficheref.HasValue)
                query.Eq("FICHEREF", Ficheref.Value);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmProdFpUsageficheline>();
        }

        public DataSet GetAll(int? Id, int? Ficheref, int? Itemref, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PROD_FP_USAGEFICHELINE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Ficheref.HasValue)
                query.Eq("FICHEREF", Ficheref.Value);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
