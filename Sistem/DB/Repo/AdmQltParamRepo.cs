using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmQltParamRepo:BaseRepository<AdmQltParam> 
    {

        public List<AdmQltParam> GetItemClass(int? Id, string Code, DateTime? Validfrom, DateTime? Validuntil, int? Ispur, int? Isprod, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_QLT_PARAM");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Code))
                query.Eq("CODE", Code);

            if(Validfrom.HasValue)
                query.Eq("VALIDFROM", Validfrom.Value);

            if(Validuntil.HasValue)
                query.Eq("VALIDUNTIL", Validuntil.Value);

            if(Ispur.HasValue)
                query.Eq("ISPUR", Ispur.Value);

            if(Isprod.HasValue)
                query.Eq("ISPROD", Isprod.Value);

            if(Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmQltParam>();
        }

        public DataSet GetAll(string LANGU, int? Id, string Code, DateTime? Validfrom, DateTime? Validuntil, int? Ispur, int? Isprod, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_QLT_PARAM");

            if (!string.IsNullOrWhiteSpace(LANGU))
            {
                query.Eq("LANGU", LANGU);
            }

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (!string.IsNullOrWhiteSpace(Code))
                query.Eq("CODE", Code);

            if (Validfrom.HasValue)
                query.Eq("VALIDFROM", Validfrom.Value);

            if (Validuntil.HasValue)
                query.Eq("VALIDUNTIL", Validuntil.Value);

            if (Ispur.HasValue)
                query.Eq("ISPUR", Ispur.Value);

            if (Isprod.HasValue)
                query.Eq("ISPROD", Isprod.Value);

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
