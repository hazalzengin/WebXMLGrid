using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmWorkorderRepo : BaseRepository<AdmWorkorder>
    {

        public List<AdmWorkorder> GetItemClass(int? Id, int? statusref, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_WORKORDER");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (statusref.HasValue)
                query.Eq("STATUSREF", statusref.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmWorkorder>();
        }

        public DataSet GetAll(string LANGU, int? statusref, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_WORKORDER");

            if (!string.IsNullOrWhiteSpace(LANGU))
            {
                query.Eq("LANGU", LANGU);
            }

            if (statusref.HasValue)
                query.Eq("STATUSREF", statusref.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
