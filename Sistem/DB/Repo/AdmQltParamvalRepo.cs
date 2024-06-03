using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmQltParamvalRepo:BaseRepository<AdmQltParamval> 
    {

        public List<AdmQltParamval> GetItemClass(int? Id, int? Paramref, string Code, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_QLT_PARAMVAL");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Paramref.HasValue)
                query.Eq("PARAMREF", Paramref.Value);

            if(!string.IsNullOrWhiteSpace(Code))
                query.Eq("CODE", Code);

            if(Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmQltParamval>();
        }

        public DataSet GetAll(string LANGU, int? Id, int? Paramref, string Code, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_QLT_PARAMVAL");

            if (!string.IsNullOrWhiteSpace(LANGU))
            {
                query.Eq("LANGU", LANGU);
            }

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Paramref.HasValue)
                query.Eq("PARAMREF", Paramref.Value);

            if (!string.IsNullOrWhiteSpace(Code))
                query.Eq("CODE", Code);

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ORDERNO", OrderDirection.Asc).ToDataSet();
        }


    }
}
