using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmWorkgroupRepo:BaseRepository<AdmWorkgroup> 
    {

        public List<AdmWorkgroup> GetItemClass(int? Id, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_WORKGROUP");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmWorkgroup>();
        }

        public DataSet GetAll(string LANGU, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_WORKGROUP");

            if (!string.IsNullOrWhiteSpace(LANGU))
            {
                query.Eq("LANGU", LANGU);
            }

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
