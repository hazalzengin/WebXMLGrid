using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class WmsTransorderheadRepo:BaseRepository<WmsTransorderhead> 
    {

        public List<WmsTransorderhead> GetItemClass(int? Id, DateTime? Date_, string Ficheno, int? Branch, int? Sourceindex, int? Sourcelocation, int? Destindex, int? Destlocation, int? Isdelete, int? Iscompleted, int? Wmsmoveficheref)
        {
            var query = new FrQueryBase(dbo);
            query.From("WMS_TRANSORDERHEAD");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Date_.HasValue)
                query.Eq("DATE_", Date_.Value);

            if(!string.IsNullOrWhiteSpace(Ficheno))
                query.Eq("FICHENO", Ficheno);

            if(Branch.HasValue)
                query.Eq("BRANCH", Branch.Value);

            if(Sourceindex.HasValue)
                query.Eq("SOURCEINDEX", Sourceindex.Value);

            if(Sourcelocation.HasValue)
                query.Eq("SOURCELOCATION", Sourcelocation.Value);

            if(Destindex.HasValue)
                query.Eq("DESTINDEX", Destindex.Value);

            if(Destlocation.HasValue)
                query.Eq("DESTLOCATION", Destlocation.Value);

            if(Isdelete.HasValue)
                query.Eq("ISDELETE", Isdelete.Value);

            if(Iscompleted.HasValue)
                query.Eq("ISCOMPLETED", Iscompleted.Value);

            if(Wmsmoveficheref.HasValue)
                query.Eq("WMSMOVEFICHEREF", Wmsmoveficheref.Value);

            return query.ToDataSet().ToFrList<WmsTransorderhead>();
        }

        public DataSet GetAll(int? Id, DateTime? Date_, string Ficheno, int? Branch, int? Sourceindex, int? Sourcelocation, int? Destindex, int? Destlocation, int? Isdelete, int? Iscompleted, int? Wmsmoveficheref)
        {
            var query = new FrQueryBase(dbo);
            query.From("WMS_TRANSORDERHEAD");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Date_.HasValue)
                query.Eq("DATE_", Date_.Value);

            if(!string.IsNullOrWhiteSpace(Ficheno))
                query.Eq("FICHENO", Ficheno);

            if(Branch.HasValue)
                query.Eq("BRANCH", Branch.Value);

            if(Sourceindex.HasValue)
                query.Eq("SOURCEINDEX", Sourceindex.Value);

            if(Sourcelocation.HasValue)
                query.Eq("SOURCELOCATION", Sourcelocation.Value);

            if(Destindex.HasValue)
                query.Eq("DESTINDEX", Destindex.Value);

            if(Destlocation.HasValue)
                query.Eq("DESTLOCATION", Destlocation.Value);

            if(Isdelete.HasValue)
                query.Eq("ISDELETE", Isdelete.Value);

            if(Iscompleted.HasValue)
                query.Eq("ISCOMPLETED", Iscompleted.Value);

            if(Wmsmoveficheref.HasValue)
                query.Eq("WMSMOVEFICHEREF", Wmsmoveficheref.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
