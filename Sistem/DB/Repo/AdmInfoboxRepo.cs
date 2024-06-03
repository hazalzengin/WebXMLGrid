using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmInfoboxRepo:BaseRepository<AdmInfobox> 
    {

        public List<AdmInfobox> GetItemClass(int? Id, int? PageId, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_INFOBOX");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(PageId.HasValue)
                query.Eq("PAGE_ID", PageId.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmInfobox>();
        }

        public DataSet GetAll(int? Id, int? PageId, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_INFOBOX");
            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(PageId.HasValue)
                query.Eq("PAGE_ID", PageId.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Asc).ToDataSet();
        }


    }
}
