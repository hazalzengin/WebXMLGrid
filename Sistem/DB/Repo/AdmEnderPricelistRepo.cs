using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmEnderPricelistRepo:BaseRepository<AdmEnderPricelist> 
    {

        public List<AdmEnderPricelist> GetItemClass(int? Id, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ENDER_PRICELIST");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmEnderPricelist>();
        }

        public DataSet GetAll(int? Id, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ENDER_PRICELIST");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
