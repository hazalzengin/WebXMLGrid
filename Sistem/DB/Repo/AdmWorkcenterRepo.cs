using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmWorkcenterRepo:BaseRepository<AdmWorkcenter> 
    {

        public List<AdmWorkcenter> GetItemClass(int? Id, int? Workgroup, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_WORKCENTER");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Workgroup.HasValue)
                query.Eq("WORKGROUP", Workgroup.Value);

            if(Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmWorkcenter>();
        }

        public DataSet GetAll(string LANGU, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_WORKCENTER");

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
