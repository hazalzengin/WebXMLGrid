using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class WmsLocationRepo:BaseRepository<WmsLocation> 
    {

        public List<WmsLocation> GetItemClass(int? Id, string Code, string Barcode, int? Branch, int? Sourceindex, int? Ispurchasearea, int? Isshippingearea, int? Isprodearea, int? Isblocked)
        {
            var query = new FrQueryBase(dbo);
            query.From("WMS_LOCATION");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Code))
                query.Eq("CODE", Code);

            if(!string.IsNullOrWhiteSpace(Barcode))
                query.Eq("BARCODE", Barcode);

            if(Branch.HasValue)
                query.Eq("BRANCH", Branch.Value);

            if(Sourceindex.HasValue)
                query.Eq("SOURCEINDEX", Sourceindex.Value);

            if (Ispurchasearea.HasValue)
                query.Eq("ISPURCHASEAREA", Ispurchasearea.Value);

            if (Isshippingearea.HasValue)
                query.Eq("ISSHIPPINGAREA", Isshippingearea.Value);

            if (Isprodearea.HasValue)
                query.Eq("ISPRODAREA", Isprodearea.Value);            

            if (Isblocked.HasValue)
                query.Eq("ISBLOCKED", Isblocked.Value);

            return query.ToDataSet().ToFrList<WmsLocation>();
        }

        public DataSet GetAll(int? Id, string Code, string Barcode, int? Branch, int? Sourceindex, int? Ispurchasearea, int? Isshippingearea, int? Isblocked)
        {
            var query = new FrQueryBase(dbo);
            query.From("WMS_LOCATION");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Code))
                query.Eq("CODE", Code);

            if(!string.IsNullOrWhiteSpace(Barcode))
                query.Eq("BARCODE", Barcode);

            if(Branch.HasValue)
                query.Eq("BRANCH", Branch.Value);

            if(Sourceindex.HasValue)
                query.Eq("SOURCEINDEX", Sourceindex.Value);

            if(Ispurchasearea.HasValue)
                query.Eq("ISPURCHASEAREA", Ispurchasearea.Value);

            if (Isshippingearea.HasValue)
                query.Eq("ISSHIPPINGAREA", Isshippingearea.Value);

            if (Isblocked.HasValue)
                query.Eq("ISBLOCKED", Isblocked.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
