using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmProdFpUsageficheRepo:BaseRepository<AdmProdFpUsagefiche> 
    {

        public List<AdmProdFpUsagefiche> GetItemClass(int? Id, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PROD_FP_USAGEFICHE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmProdFpUsagefiche>();
        }

        public DataSet GetAll(int? Id, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PROD_FP_USAGEFICHE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
