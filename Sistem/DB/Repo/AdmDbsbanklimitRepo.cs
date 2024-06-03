using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmDbsbanklimitRepo:BaseRepository<AdmDbsbanklimit> 
    {

        public List<AdmDbsbanklimit> GetItemClass(int? Id, string Dbsclcode, string Dbsbncode, int? Dbsactive, int? Sign)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_DBSBANKLIMIT");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Dbsclcode))
                query.Eq("DBSCLCODE", Dbsclcode);

            if(!string.IsNullOrWhiteSpace(Dbsbncode))
                query.Eq("DBSBNCODE", Dbsbncode);

            if(Dbsactive.HasValue)
                query.Eq("DBSACTIVE", Dbsactive.Value);

            if(Sign.HasValue)
                query.Eq("SIGN", Sign.Value);

            return query.ToDataSet().ToFrList<AdmDbsbanklimit>();
        }

        public DataSet GetAll(int? Id, string Dbsclcode, string Dbsbncode, int? Dbsactive, int? Sign)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_DBSBANKLIMIT");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Dbsclcode))
                query.Eq("DBSCLCODE", Dbsclcode);

            if(!string.IsNullOrWhiteSpace(Dbsbncode))
                query.Eq("DBSBNCODE", Dbsbncode);

            if(Dbsactive.HasValue)
                query.Eq("DBSACTIVE", Dbsactive.Value);

            if(Sign.HasValue)
                query.Eq("SIGN", Sign.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
