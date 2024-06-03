using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmPrdStopcodeRepo:BaseRepository<AdmPrdStopcode> 
    {

        public List<AdmPrdStopcode> GetItemClass(int? Id, string Code, string Name, int? Isactive)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PRD_STOPCODE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Code))
                query.Eq("CODE", Code);

            if(!string.IsNullOrWhiteSpace(Name))
                query.Eq("NAME", Name);

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            return query.ToDataSet().ToFrList<AdmPrdStopcode>();
        }

        public DataSet GetAll(int? Id, string Code, string Name, int? Isactive)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PRD_STOPCODE");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (!string.IsNullOrWhiteSpace(Code))
                query.Eq("CODE", Code);

            if (!string.IsNullOrWhiteSpace(Name))
                query.Eq("NAME", Name);

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);
            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
