using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmCashflowDelayRepo:BaseRepository<AdmCashflowDelay> 
    {

        public List<AdmCashflowDelay> GetItemClass(int? Id, int? Modul, int? Parentref)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_CASHFLOW_DELAY");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Modul.HasValue)
                query.Eq("MODUL", Modul.Value);

            if(Parentref.HasValue)
                query.Eq("PARENTREF", Parentref.Value);

            return query.ToDataSet().ToFrList<AdmCashflowDelay>();
        }

        public DataSet GetAll(int? Id, int? Modul, int? Parentref, DateTime? Fichedate, DateTime? Fichedate2)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_CASHFLOW_DELAY");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Modul.HasValue)
                query.Eq("MODUL", Modul.Value);

            if (Parentref.HasValue)
                query.Eq("PARENTREF", Parentref.Value);

            if (Fichedate.HasValue && Fichedate2.HasValue)
            {
                query.Between("FICHEDATE", Fichedate.Value, Fichedate2.Value);
            }
            else
            {
                if (Fichedate.HasValue)
                    query.Eq("FICHEDATE", Fichedate.Value);
            }
            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
