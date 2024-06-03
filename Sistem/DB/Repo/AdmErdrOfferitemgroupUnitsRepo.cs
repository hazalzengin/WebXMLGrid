using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmErdrOfferitemgroupUnitsRepo:BaseRepository<AdmErdrOfferitemgroupUnits> 
    {

        public List<AdmErdrOfferitemgroupUnits> GetItemClass(int? Id, int? Orderno, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ERDR_OFFERITEMGROUP_UNITS");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            if(Orderno.HasValue)
                query.Eq("ORDERNO", Orderno.Value);

            return query.ToDataSet().ToFrList<AdmErdrOfferitemgroupUnits>();
        }

        public DataSet GetAll(int? Id,int? Orderno, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ERDR_OFFERITEMGROUP_UNITS");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            if(Orderno.HasValue)
                query.Eq("ORDERNO", Orderno.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
