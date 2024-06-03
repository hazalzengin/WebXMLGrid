using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmTmzOfferitemsRepo:BaseRepository<AdmTmzOfferitems> 
    {

        public List<AdmTmzOfferitems> GetItemClass(int? Id, int? Parentref, int? Itemgroupref, int? Isatlasitem
            , int? Itemref,String itemcode,int? isCurrent, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_TMZ_OFFERITEMS");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Parentref.HasValue)
                query.Eq("PARENTREF", Parentref.Value);

            if(Itemgroupref.HasValue)
                query.Eq("ITEMGROUPREF", Itemgroupref.Value);

            if(Isatlasitem.HasValue)
                query.Eq("ISATLASITEM", Isatlasitem.Value);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if (isCurrent.HasValue)
                query.Eq("ISCURRENT", isCurrent.Value);

            if (!String.IsNullOrEmpty(itemcode)) query.Eq("ITEMCODE", itemcode);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("REVIZYON,REPEAT", OrderDirection.Desc).ToDataSet().ToFrList<AdmTmzOfferitems>();
        }

        public DataSet GetAll(int? Id, int? Parentref, int? Itemgroupref, int? Isatlasitem
            , int? Itemref, String itemcode, int? isCurrent, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_TMZ_OFFERITEMS");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Parentref.HasValue)
                query.Eq("PARENTREF", Parentref.Value);

            if(Itemgroupref.HasValue)
                query.Eq("ITEMGROUPREF", Itemgroupref.Value);

            if(Isatlasitem.HasValue)
                query.Eq("ISATLASITEM", Isatlasitem.Value);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if (isCurrent.HasValue)
                query.Eq("ISCURRENT", isCurrent.Value);

            if (!String.IsNullOrEmpty(itemcode)) query.Eq("ITEMCODE", itemcode);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
