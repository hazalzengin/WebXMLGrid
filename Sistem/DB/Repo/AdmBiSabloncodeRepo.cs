using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmBiSabloncodeRepo:BaseRepository<AdmBiSabloncode> 
    {

        public List<AdmBiSabloncode> GetItemClass(int? Id, string Mastercode, string Code, int? Isactive,String orderBy)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_BI_SABLONCODE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Mastercode))
                query.Eq("MASTERCODE", Mastercode);

            if(!string.IsNullOrWhiteSpace(Code))
                query.Eq("CODE", Code);

            if(Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            return query.OrderBy(String.IsNullOrEmpty(orderBy) ? "SIRA" : orderBy, OrderDirection.Asc).ToDataSet().ToFrList<AdmBiSabloncode>();
        }

        public DataSet GetAll(int? Id, string Mastercode, string Code, int? Isactive)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_BI_SABLONCODE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Mastercode))
                query.Eq("MASTERCODE", Mastercode);

            if(!string.IsNullOrWhiteSpace(Code))
                query.Eq("CODE", Code);

            if(Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            return query.OrderBy("SIRA", OrderDirection.Asc).ToDataSet();
        }


    }
}
