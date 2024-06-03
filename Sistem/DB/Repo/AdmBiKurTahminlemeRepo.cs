using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmBiKurTahminlemeRepo:BaseRepository<AdmBiKurTahminleme> 
    {

        public List<AdmBiKurTahminleme> GetItemClass(int? Id, int? Currencytype, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_BI_KUR_TAHMINLEME");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Currencytype.HasValue)
                query.Eq("CURRENCYTYPE", Currencytype.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmBiKurTahminleme>();
        }

        public DataSet GetAll(int? Id, int? Currencytype, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_BI_KUR_TAHMINLEME");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Currencytype.HasValue)
                query.Eq("CURRENCYTYPE", Currencytype.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
