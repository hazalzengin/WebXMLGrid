using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmPurOrderitemRepo:BaseRepository<AdmPurOrderitem> 
    {

        public List<AdmPurOrderitem> GetItemClass(int? Id, int? Orderref, int? Itemref, string Itemcode, string Unit, string Currency, DateTime? Duedate)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PUR_ORDERITEM");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Orderref.HasValue)
                query.Eq("ORDERREF", Orderref.Value);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if(!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if(!string.IsNullOrWhiteSpace(Unit))
                query.Eq("UNIT", Unit);

            if(!string.IsNullOrWhiteSpace(Currency))
                query.Eq("CURRENCY", Currency);

            if(Duedate.HasValue)
                query.Eq("DUEDATE", Duedate.Value);

            return query.ToDataSet().ToFrList<AdmPurOrderitem>();
        }

        public DataSet GetAll(int? Id, int? Orderref, int? Itemref, string Itemcode, string Unit, string Currency, DateTime? Duedate)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PUR_ORDERITEM");
            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
