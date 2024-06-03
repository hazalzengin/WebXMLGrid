using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmDbsconnectionRepo:BaseRepository<AdmDbsconnection> 
    {

        public List<AdmDbsconnection> GetItemClass(int? Id, int? Clref, int? Dbsref, int? Conref, int? Sign, int? Invoiceref)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_DBSCONNECTION");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Clref.HasValue)
                query.Eq("CLREF", Clref.Value);

            if(Dbsref.HasValue)
                query.Eq("DBSREF", Dbsref.Value);

            if(Conref.HasValue)
                query.Eq("CONREF", Conref.Value);

            if(Sign.HasValue)
                query.Eq("SIGN", Sign.Value);

            if(Invoiceref.HasValue)
                query.Eq("INVOICEREF", Invoiceref.Value);

            return query.ToDataSet().ToFrList<AdmDbsconnection>();
        }

        public DataSet GetAll(int? Id, int? Clref, int? Dbsref, int? Conref, int? Sign, int? Invoiceref)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_DBSCONNECTION");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Clref.HasValue)
                query.Eq("CLREF", Clref.Value);

            if(Dbsref.HasValue)
                query.Eq("DBSREF", Dbsref.Value);

            if(Conref.HasValue)
                query.Eq("CONREF", Conref.Value);

            if(Sign.HasValue)
                query.Eq("SIGN", Sign.Value);

            if(Invoiceref.HasValue)
                query.Eq("INVOICEREF", Invoiceref.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
