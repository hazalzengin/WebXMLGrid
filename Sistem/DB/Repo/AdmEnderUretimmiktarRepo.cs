using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmEnderUretimmiktarRepo:BaseRepository<AdmEnderUretimmiktar> 
    {

        public List<AdmEnderUretimmiktar> GetItemClass(int? Id, int? Year_, int? Month_)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ENDER_URETIMMIKTAR");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Year_.HasValue)
                query.Eq("YEAR_", Year_.Value);

            if(Month_.HasValue)
                query.Eq("MONTH_", Month_.Value);

            return query.ToDataSet().ToFrList<AdmEnderUretimmiktar>();
        }

        public DataSet GetAll(int? Id, int? Year_, int? Month_)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_ENDER_URETIMMIKTAR");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Year_.HasValue)
                query.Eq("YEAR_", Year_.Value);

            if(Month_.HasValue)
                query.Eq("MONTH_", Month_.Value);

            return query.OrderBy("ID", OrderDirection.Asc).ToDataSet();
        }


    }
}
