using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmPrdtypeRepo:BaseRepository<AdmPrdtype> 
    {

        public List<AdmPrdtype> GetItemClass(int? Id, string code, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PRDTYPE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if (!string.IsNullOrWhiteSpace(code))
            {
                query.Eq("CODE", code);
            }

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmPrdtype>();
        }

        public DataSet GetAll(string LANGU, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_PRDTYPE");

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
