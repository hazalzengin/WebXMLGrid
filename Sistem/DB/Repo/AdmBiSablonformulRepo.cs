using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmBiSablonformulRepo:BaseRepository<AdmBiSablonformul> 
    {

        public List<AdmBiSablonformul> GetItemClass(int? Id, string Mastercode)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_BI_SABLONFORMUL");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Mastercode))
                query.Eq("MASTERCODE", Mastercode);

            return query.ToDataSet().ToFrList<AdmBiSablonformul>();
        }

        public DataSet GetAll(int? Id, string Mastercode)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_BI_SABLONFORMUL");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Mastercode))
                query.Eq("MASTERCODE", Mastercode);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
