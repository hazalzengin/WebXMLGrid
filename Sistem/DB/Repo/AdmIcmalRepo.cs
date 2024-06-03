using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmIcmalRepo:BaseRepository<AdmIcmal> 
    {

        public List<AdmIcmal> GetItemClass(int? Id, decimal? Amount, decimal? Firmamf, decimal? Depomf)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ICMAL");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Amount.HasValue)
                query.Eq("AMOUNT", Amount.Value);

            if(Firmamf.HasValue)
                query.Eq("FIRMAMF", Firmamf.Value);

            if(Depomf.HasValue)
                query.Eq("DEPOMF", Depomf.Value);

            return query.ToDataSet().ToFrList<AdmIcmal>();
        }

        public DataSet GetAll(int? Id, decimal? Amount, decimal? Firmamf, decimal? Depomf)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ICMAL");
            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
