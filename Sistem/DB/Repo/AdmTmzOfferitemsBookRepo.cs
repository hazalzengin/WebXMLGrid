using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmTmzOfferitemsBookRepo:BaseRepository<AdmTmzOfferitemsBook> 
    {

        public List<AdmTmzOfferitemsBook> GetItemClass(int? Id, int? Offerref, int? Offeritemref, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_TMZ_OFFERITEMS_BOOK");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Offerref.HasValue)
                query.Eq("OFFERREF", Offerref.Value);

            if(Offeritemref.HasValue)
                query.Eq("OFFERITEMREF", Offeritemref.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmTmzOfferitemsBook>();
        }

        public DataSet GetAll(int? Id, int? Offerref, int? Offeritemref, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_TMZ_OFFERITEMS_BOOK");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Offerref.HasValue)
                query.Eq("OFFERREF", Offerref.Value);

            if(Offeritemref.HasValue)
                query.Eq("OFFERITEMREF", Offeritemref.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
