using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmModuleConfRepo:BaseRepository<AdmModuleConf> 
    {

        public List<AdmModuleConf> GetItemClass(int? Id, string Modulecode, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_MODULE_CONF");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Modulecode))
                query.Eq("MODULECODE", Modulecode);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmModuleConf>();
        }

        public DataSet GetAll(int? Id, string Modulecode, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_MODULE_CONF");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Modulecode))
                query.Eq("MODULECODE", Modulecode);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
