using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmSysWebreportRepo:BaseRepository<AdmSysWebreport> 
    {

        public List<AdmSysWebreport> GetItemClass(int? Id,string code, int? Virgul, int? Tur, int? Sira)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_SYS_WEBREPORT");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);
            if (!String.IsNullOrEmpty(code)) query.Eq("REPORTCODE", code);

            if (Virgul.HasValue)
                query.Eq("VIRGUL", Virgul.Value);

            if(Tur.HasValue)
                query.Eq("TUR", Tur.Value);

            if(Sira.HasValue)
                query.Eq("SIRA", Sira.Value);

            return query.ToDataSet().ToFrList<AdmSysWebreport>();
        }

        public DataSet GetAll(int? Id, int? Virgul, int? Tur, int? Sira)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_SYS_WEBREPORT");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Virgul.HasValue)
                query.Eq("VIRGUL", Virgul.Value);

            if(Tur.HasValue)
                query.Eq("TUR", Tur.Value);

            if(Sira.HasValue)
                query.Eq("SIRA", Sira.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
