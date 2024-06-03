using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmErdrOfferitemgroupNamesRepo:BaseRepository<AdmErdrOfferitemgroupNames> 
    {

        public List<AdmErdrOfferitemgroupNames> GetItemClass(int? Id, string Marka, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ERDR_OFFERITEMGROUP_NAMES");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if (!string.IsNullOrWhiteSpace(Marka))
                query.Eq("MARKA", Marka);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmErdrOfferitemgroupNames>();
        }

        public DataSet GetAll(int? Id, string Marka, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ERDR_OFFERITEMGROUP_NAMES");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if (!string.IsNullOrWhiteSpace(Marka))
                query.Eq("MARKA", Marka);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
