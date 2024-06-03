using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmSalesprofitdataRepo:BaseRepository<AdmSalesprofitdata> 
    {

        public List<AdmSalesprofitdata> GetItemClass(int? Id, string Firmnr, string Period, string Clcode, string Itemcode)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_SALESPROFITDATA");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Firmnr))
                query.Eq("FIRMNR", Firmnr);

            if(!string.IsNullOrWhiteSpace(Period))
                query.Eq("PERIOD", Period);

            if(!string.IsNullOrWhiteSpace(Clcode))
                query.Eq("CLCODE", Clcode);

            if(!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            return query.ToDataSet().ToFrList<AdmSalesprofitdata>();
        }

        public DataSet GetAll(int? Id, string Firmnr, string Period, string Clcode, string Itemcode)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_SALESPROFITDATA");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Firmnr))
                query.Eq("FIRMNR", Firmnr);

            if(!string.IsNullOrWhiteSpace(Period))
                query.Eq("PERIOD", Period);

            if(!string.IsNullOrWhiteSpace(Clcode))
                query.Eq("CLCODE", Clcode);

            if(!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
