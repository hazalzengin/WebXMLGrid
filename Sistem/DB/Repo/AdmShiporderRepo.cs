using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmShiporderRepo:BaseRepository<AdmShiporder> 
    {

        public List<AdmShiporder> GetItemClass(int? Id, DateTime? Date_, int? Statusref, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_SHIPORDER");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Date_.HasValue)
                query.Eq("DATE_", Date_.Value);

            if(Statusref.HasValue)
                query.Eq("STATUSREF", Statusref.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmShiporder>();
        }

        public DataSet GetAll(int? Id, DateTime? Date_, int? Statusref, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_SHIPORDER");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Date_.HasValue)
                query.Eq("DATE_", Date_.Value);

            if (Statusref.HasValue)
                query.Eq("STATUSREF", Statusref.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
