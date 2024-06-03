using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmLoadingorderRepo:BaseRepository<AdmLoadingorder> 
    {

        public List<AdmLoadingorder> GetItemClass(int? Id, int? Statusref, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_LOADINGORDER");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Statusref.HasValue)
                query.Eq("STATUSREF", Statusref.Value);

            if(Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmLoadingorder>();
        }

        public DataSet GetAll(string LANGU, int? statusref, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_LOADINGORDER");

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
