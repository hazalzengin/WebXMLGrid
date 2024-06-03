using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class WmsWhchecklineRepo:BaseRepository<WmsWhcheckline> 
    {

        public List<WmsWhcheckline> GetItemClass(int? Id, int? Headref, int? Itemref, string Itemcode, string Barcode, int? Location, int? Uomref, int? Iscompleted, int? Movelineref, int? Isnew)
        {
            var query = new FrQueryBase(dbo);
            query.From("WMS_WHCHECKLINE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Headref.HasValue)
                query.Eq("HEADREF", Headref.Value);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if(!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if(!string.IsNullOrWhiteSpace(Barcode))
                query.Eq("BARCODE", Barcode);

            if(Location.HasValue)
                query.Eq("LOCATION", Location.Value);

            if(Uomref.HasValue)
                query.Eq("UOMREF", Uomref.Value);

            if(Iscompleted.HasValue)
                query.Eq("ISCOMPLETED", Iscompleted.Value);

            if(Movelineref.HasValue)
                query.Eq("MOVELINEREF", Movelineref.Value);

            if(Isnew.HasValue)
                query.Eq("ISNEW", Isnew.Value);

            return query.ToDataSet().ToFrList<WmsWhcheckline>();
        }

        public DataSet GetAll(int? Id, int? Headref, int? Itemref, string Itemcode, string Barcode, int? Location, int? Uomref, int? Iscompleted, int? Movelineref, int? Isnew)
        {
            var query = new FrQueryBase(dbo);
            query.From("WMS_WHCHECKLINE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Headref.HasValue)
                query.Eq("HEADREF", Headref.Value);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if(!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if(!string.IsNullOrWhiteSpace(Barcode))
                query.Eq("BARCODE", Barcode);

            if(Location.HasValue)
                query.Eq("LOCATION", Location.Value);

            if(Uomref.HasValue)
                query.Eq("UOMREF", Uomref.Value);

            if(Iscompleted.HasValue)
                query.Eq("ISCOMPLETED", Iscompleted.Value);

            if(Movelineref.HasValue)
                query.Eq("MOVELINEREF", Movelineref.Value);

            if(Isnew.HasValue)
                query.Eq("ISNEW", Isnew.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
