using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class WmsMovelineQualityRepo:BaseRepository<WmsMovelineQuality> 
    {

        public List<WmsMovelineQuality> GetItemClass(int? Id, int? Orderref, int? Oprref, string Barcode, int? Qualitystatus)
        {
            var query = new FrQueryBase(dbo);
            query.From("WMS_MOVELINE_QUALITY");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Orderref.HasValue)
                query.Eq("ORDERREF", Orderref.Value);

            if(Oprref.HasValue)
                query.Eq("OPRREF", Oprref.Value);

            if(!string.IsNullOrWhiteSpace(Barcode))
                query.Eq("BARCODE", Barcode);

            if(Qualitystatus.HasValue)
                query.Eq("QUALITYSTATUS", Qualitystatus.Value);

            return query.ToDataSet().ToFrList<WmsMovelineQuality>();
        }

        public DataSet GetAll(int? Id, int? Orderref, int? Oprref, string Barcode, int? Qualitystatus)
        {
            var query = new FrQueryBase(dbo);
            query.From("WMS_MOVELINE_QUALITY");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Orderref.HasValue)
                query.Eq("ORDERREF", Orderref.Value);

            if(Oprref.HasValue)
                query.Eq("OPRREF", Oprref.Value);

            if(!string.IsNullOrWhiteSpace(Barcode))
                query.Eq("BARCODE", Barcode);

            if(Qualitystatus.HasValue)
                query.Eq("QUALITYSTATUS", Qualitystatus.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
