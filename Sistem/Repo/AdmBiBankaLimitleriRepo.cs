using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmBiBankaLimitleriRepo:BaseRepository<AdmBiBankaLimitleri> 
    {

        public List<AdmBiBankaLimitleri> GetItemClass(int? Id, int? Bankref, int? Firmnr, int? Currency, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_BI_BANKA_LIMITLERI");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Bankref.HasValue)
                query.Eq("BANKREF", Bankref.Value);

            if(Firmnr.HasValue)
                query.Eq("FIRMNR", Firmnr.Value);

            if(Currency.HasValue)
                query.Eq("CURRENCY", Currency.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmBiBankaLimitleri>();
        }

        public DataSet GetAll(int? Id, int? Bankref, int? Firmnr, int? Currency, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_BI_BANKA_LIMITLERI");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Bankref.HasValue)
                query.Eq("BANKREF", Bankref.Value);

            if(Firmnr.HasValue)
                query.Eq("FIRMNR", Firmnr.Value);

            if(Currency.HasValue)
                query.Eq("CURRENCY", Currency.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
