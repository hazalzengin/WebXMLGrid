using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmCompanyRepo : BaseRepository<AdmCompany>
    {

        public List<AdmCompany> GetItemClass(int? Id, string Code, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_COMPANY");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (!string.IsNullOrWhiteSpace(Code))
                query.Eq("CODE", Code);

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmCompany>();
        }

        public DataSet GetAll(int? Id, string Code, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_COMPANY");


            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (!string.IsNullOrWhiteSpace(Code))
                query.Eq("CODE", Code);


            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
