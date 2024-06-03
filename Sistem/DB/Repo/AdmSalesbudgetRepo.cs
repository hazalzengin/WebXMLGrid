using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmSalesbudgetRepo:BaseRepository<AdmSalesbudget> 
    {

        public List<AdmSalesbudget> GetItemClass(int? Id, string Salesmancode, string Clientcode, string Itemcode, string Firmnr, int? Type_)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_SALESBUDGET");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Salesmancode))
                query.Eq("SALESMANCODE", Salesmancode);

            if(!string.IsNullOrWhiteSpace(Clientcode))
                query.Eq("CLIENTCODE", Clientcode);

            if(!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if(!string.IsNullOrWhiteSpace(Firmnr))
                query.Eq("FIRMNR", Firmnr);

            if(Type_.HasValue)
                query.Eq("TYPE_", Type_.Value);

            return query.ToDataSet().ToFrList<AdmSalesbudget>();
        }

        public DataSet GetAll()
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_SALESBUDGET");
            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
