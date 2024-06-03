using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmBiSablonRepo:BaseRepository<AdmBiSablon> 
    {

        public List<AdmBiSablon> GetItemClass(int? Id, string Code, int? Isactive, int? Type_)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_BI_SABLON");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Code))
                query.Eq("CODE", Code);

            if(Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if(Type_.HasValue)
                query.Eq("TYPE_", Type_.Value);

            return query.ToDataSet().ToFrList<AdmBiSablon>();
        }

        public DataSet GetAll(int? Id, string Code, int? Isactive, int? Type_)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_BI_SABLON");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Code))
                query.Eq("CODE", Code);

            if(Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if(Type_.HasValue)
                query.Eq("TYPE_", Type_.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
