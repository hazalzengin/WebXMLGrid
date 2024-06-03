using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class WmsItembarcodeRepo:BaseRepository<WmsItembarcode> 
    {

        public List<WmsItembarcode> GetItemClass(int? Id, string Barcode, int? Itemref, string Itemcode, int? Uomref)
        {
            var query = new FrQueryBase(dbo);
            query.From("WMS_ITEMBARCODE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Barcode))
                query.Eq("BARCODE", Barcode);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if(!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if(Uomref.HasValue)
                query.Eq("UOMREF", Uomref.Value);

            return query.ToDataSet().ToFrList<WmsItembarcode>();
        }

        public DataSet GetAll(int? Id, string Barcode, int? Itemref, string Itemcode, int? Uomref)
        {
            var query = new FrQueryBase(dbo);
            query.From("WMS_ITEMBARCODE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Barcode))
                query.Eq("BARCODE", Barcode);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if(!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if(Uomref.HasValue)
                query.Eq("UOMREF", Uomref.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
