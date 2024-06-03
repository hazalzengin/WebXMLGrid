using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class WmsMovelineRepo:BaseRepository<WmsMoveline> 
    {

        public List<WmsMoveline> GetItemClass(int? Id, int? Ficheref, int? Trcode, int? Iocode, int? Itemref, string Itemcode, int? Uomref
            , int? Isdelete, int? Locationref, int? Branch, int? Sourceindex, int? Istransferred, int? Llineref, String barcode, int? WmsParentref)
        {
            var query = new FrQueryBase(dbo);
            query.From("WMS_MOVELINE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Ficheref.HasValue)
                query.Eq("FICHEREF", Ficheref.Value);

            if(Trcode.HasValue)
                query.Eq("TRCODE", Trcode.Value);

            if(Iocode.HasValue)
                query.Eq("IOCODE", Iocode.Value);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if(!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if(Uomref.HasValue)
                query.Eq("UOMREF", Uomref.Value);

            if(Isdelete.HasValue)
                query.Eq("ISDELETE", Isdelete.Value);

            if(Locationref.HasValue)
                query.Eq("LOCATIONREF", Locationref.Value);

            if(Branch.HasValue)
                query.Eq("BRANCH", Branch.Value);

            if(Sourceindex.HasValue)
                query.Eq("SOURCEINDEX", Sourceindex.Value);

            if(Istransferred.HasValue)
                query.Eq("ISTRANSFERRED", Istransferred.Value);

            if(Llineref.HasValue)
                query.Eq("LLINEREF", Llineref.Value);

            if (!string.IsNullOrWhiteSpace(barcode))
                query.Eq("BARCODE", barcode);

            if (WmsParentref.HasValue)
                query.Eq("WMSPARENTREF", WmsParentref.Value);

            return query.ToDataSet().ToFrList<WmsMoveline>();
        }

        public DataSet GetAll(int? Id, int? Ficheref, int? Trcode, int? Iocode, int? Itemref, string Itemcode, int? Uomref
            , int? Isdelete, int? Locationref, int? Branch, int? Sourceindex, int? Istransferred, int? Llineref, String barcode, int? WmsParentref)
        {
            var query = new FrQueryBase(dbo);
            query.From("WMS_MOVELINE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Ficheref.HasValue)
                query.Eq("FICHEREF", Ficheref.Value);

            if(Trcode.HasValue)
                query.Eq("TRCODE", Trcode.Value);

            if(Iocode.HasValue)
                query.Eq("IOCODE", Iocode.Value);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if(!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if(Uomref.HasValue)
                query.Eq("UOMREF", Uomref.Value);

            if(Isdelete.HasValue)
                query.Eq("ISDELETE", Isdelete.Value);

            if(Locationref.HasValue)
                query.Eq("LOCATIONREF", Locationref.Value);

            if(Branch.HasValue)
                query.Eq("BRANCH", Branch.Value);

            if(Sourceindex.HasValue)
                query.Eq("SOURCEINDEX", Sourceindex.Value);

            if(Istransferred.HasValue)
                query.Eq("ISTRANSFERRED", Istransferred.Value);

            if(Llineref.HasValue)
                query.Eq("LLINEREF", Llineref.Value);

            if (!string.IsNullOrWhiteSpace(barcode))
                query.Eq("BARCODE", barcode);

            if (WmsParentref.HasValue)
                query.Eq("WMSPARENTREF", WmsParentref.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }
    }
}
