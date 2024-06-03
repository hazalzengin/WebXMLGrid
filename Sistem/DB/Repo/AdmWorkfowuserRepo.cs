using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmWorkfowuserRepo:BaseRepository<AdmWorkfowuser> 
    {

        public List<AdmWorkfowuser> GetItemClass(int? Id, int? Isclient, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_WORKFOWUSER");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Isclient.HasValue)
                query.Eq("ISCLIENT", Isclient.Value);

            if(Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmWorkfowuser>();
        }

        public DataSet GetAll()
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_WORKFOWUSER");
            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
