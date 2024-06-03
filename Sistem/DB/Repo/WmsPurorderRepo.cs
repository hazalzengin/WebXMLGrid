using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class WmsPurorderRepo:BaseRepository<WmsPurorder> 
    {

        public List<WmsPurorder> GetItemClass(int? Id, DateTime? Date_, int? Statusref, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("WMS_PURORDER");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Date_.HasValue)
                query.Eq("DATE_", Date_.Value);

            if(Statusref.HasValue)
                query.Eq("STATUSREF", Statusref.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<WmsPurorder>();
        }

        public DataSet GetAll(int? Id, DateTime? Date_, int? Statusref, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("WMS_PURORDER");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Date_.HasValue)
                query.Eq("DATE_", Date_.Value);

            if(Statusref.HasValue)
                query.Eq("STATUSREF", Statusref.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
