using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class WmsTempShiporderlineRepo:BaseRepository<WmsTempShiporderline> 
    {

        public List<WmsTempShiporderline> GetItemClass(int? Id, int? Orderref, string Barcode, int? Itemref, string Itemcode, int? Branch, int? Sourceindex, int? Locationref, int? Istransferred)
        {
            var query = new FrQueryBase(dbo);
            query.From("WMS_TEMP_SHIPORDERLINE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Orderref.HasValue)
                query.Eq("ORDERREF", Orderref.Value);

            if(!string.IsNullOrWhiteSpace(Barcode))
                query.Eq("BARCODE", Barcode);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if(!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if(Branch.HasValue)
                query.Eq("BRANCH", Branch.Value);

            if(Sourceindex.HasValue)
                query.Eq("SOURCEINDEX", Sourceindex.Value);

            if(Locationref.HasValue)
                query.Eq("LOCATIONREF", Locationref.Value);

            if(Istransferred.HasValue)
                query.Eq("ISTRANSFERRED", Istransferred.Value);

            return query.ToDataSet().ToFrList<WmsTempShiporderline>();
        }

        public DataSet GetAll(int? Id, int? Orderref, string Barcode, int? Itemref, string Itemcode, int? Branch, int? Sourceindex, int? Locationref, int? Istransferred)
        {
            var query = new FrQueryBase(dbo);
            query.From("WMS_TEMP_SHIPORDERLINE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Orderref.HasValue)
                query.Eq("ORDERREF", Orderref.Value);

            if(!string.IsNullOrWhiteSpace(Barcode))
                query.Eq("BARCODE", Barcode);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if(!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if(Branch.HasValue)
                query.Eq("BRANCH", Branch.Value);

            if(Sourceindex.HasValue)
                query.Eq("SOURCEINDEX", Sourceindex.Value);

            if(Locationref.HasValue)
                query.Eq("LOCATIONREF", Locationref.Value);

            if(Istransferred.HasValue)
                query.Eq("ISTRANSFERRED", Istransferred.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
