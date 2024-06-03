using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmBiSablonresultRepo:BaseRepository<AdmBiSablonresult> 
    {

        public List<AdmBiSablonresult> GetItemClass(int? Id, string Mastercode, string Code)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_BI_SABLONRESULT");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Mastercode))
                query.Eq("MASTERCODE", Mastercode);

            if(!string.IsNullOrWhiteSpace(Code))
                query.Eq("CODE", Code);

            return query.ToDataSet().ToFrList<AdmBiSablonresult>();
        }

        public DataSet GetAll(int? Id, string Mastercode, string Code)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_BI_SABLONRESULT");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Mastercode))
                query.Eq("MASTERCODE", Mastercode);

            if(!string.IsNullOrWhiteSpace(Code))
                query.Eq("CODE", Code);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
