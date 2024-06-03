using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmPrdpersonnelRepo:BaseRepository<AdmPrdpersonnel> 
    {

        public List<AdmPrdpersonnel> GetItemClass(int? Id, string Code, string Workgroup, string Workcenter, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PRDPERSONNEL");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Code))
                query.Eq("CODE", Code);

            if(!string.IsNullOrWhiteSpace(Workgroup))
                query.Eq("WORKGROUP", Workgroup);

            if(!string.IsNullOrWhiteSpace(Workcenter))
                query.Eq("WORKCENTER", Workcenter);

            if(Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmPrdpersonnel>();
        }

        public DataSet GetAll(int? Id, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PRDPERSONNEL");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);


            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
