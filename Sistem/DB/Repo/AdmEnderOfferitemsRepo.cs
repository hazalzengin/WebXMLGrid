using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmEnderOfferitemsRepo:BaseRepository<AdmEnderOfferitems> 
    {

        public List<AdmEnderOfferitems> GetItemClass(int? Id, int? Offerref, int? Itemref, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ENDER_OFFERITEMS");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Offerref.HasValue)
                query.Eq("OFFERREF", Offerref.Value);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmEnderOfferitems>();
        }

        public DataSet GetAll(int? Id, int? Offerref, int? Itemref, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ENDER_OFFERITEMS");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Offerref.HasValue)
                query.Eq("OFFERREF", Offerref.Value);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
