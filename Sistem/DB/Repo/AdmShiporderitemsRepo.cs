using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmShiporderitemsRepo:BaseRepository<AdmShiporderitems> 
    {

        public List<AdmShiporderitems> GetItemClass(int? Id, int? Parentref, int? Orderref, int? Orderlineref, int? Itemref,  int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_SHIPORDERITEMS");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Parentref.HasValue)
                query.Eq("PARENTREF", Parentref.Value);

            if(Orderref.HasValue)
                query.Eq("ORDERREF", Orderref.Value);

            if(Orderlineref.HasValue)
                query.Eq("ORDERLINEREF", Orderlineref.Value);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmShiporderitems>();
        }

        public DataSet GetAll(int? Id, int? Parentref, int? Orderref, int? Orderlineref, int? Itemref,  int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_SHIPORDERITEMS");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Parentref.HasValue)
                query.Eq("PARENTREF", Parentref.Value);

            if (Orderref.HasValue)
                query.Eq("ORDERREF", Orderref.Value);

            if (Orderlineref.HasValue)
                query.Eq("ORDERLINEREF", Orderlineref.Value);

            if (Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
