using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmWorkorderitemsRepo:BaseRepository<AdmWorkorderitems> 
    {

        public List<AdmWorkorderitems> GetItemClass(int? Id, int? Workorderref, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_WORKORDERITEMS");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Workorderref.HasValue)
                query.Eq("WORKORDERREF", Workorderref.Value);

            if(Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmWorkorderitems>();
        }

        public DataSet GetAll(int? Workorderref, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_WORKORDERITEMS");

            if (Workorderref.HasValue)
                query.Eq("WORKORDERREF", Workorderref.Value);

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Asc).ToDataSet();
        }


    }
}
