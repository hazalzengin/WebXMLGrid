using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class WmsTransorderlineRepo:BaseRepository<WmsTransorderline> 
    {

        public List<WmsTransorderline> GetItemClass(int? Id, int? Headref, int? Itemref, string Itemcode, int? Uomref, int? Iscompleted, int? Wmsmovelineref)
        {
            var query = new FrQueryBase(dbo);
            query.From("WMS_TRANSORDERLINE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Headref.HasValue)
                query.Eq("HEADREF", Headref.Value);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if(!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if(Uomref.HasValue)
                query.Eq("UOMREF", Uomref.Value);

            if(Iscompleted.HasValue)
                query.Eq("ISCOMPLETED", Iscompleted.Value);

            if(Wmsmovelineref.HasValue)
                query.Eq("WMSMOVELINEREF", Wmsmovelineref.Value);

            return query.ToDataSet().ToFrList<WmsTransorderline>();
        }

        public DataSet GetAll(int? Id, int? Headref, int? Itemref, string Itemcode, int? Uomref, int? Iscompleted, int? Wmsmovelineref)
        {
            var query = new FrQueryBase(dbo);
            query.From("WMS_TRANSORDERLINE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Headref.HasValue)
                query.Eq("HEADREF", Headref.Value);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if(!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if(Uomref.HasValue)
                query.Eq("UOMREF", Uomref.Value);

            if(Iscompleted.HasValue)
                query.Eq("ISCOMPLETED", Iscompleted.Value);

            if(Wmsmovelineref.HasValue)
                query.Eq("WMSMOVELINEREF", Wmsmovelineref.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
