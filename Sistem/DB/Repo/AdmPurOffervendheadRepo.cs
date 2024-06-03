using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmPurOffervendheadRepo:BaseRepository<AdmPurOffervendhead> 
    {

        public List<AdmPurOffervendhead> GetItemClass(int? Id, int? Offerref, int? Firmref, string Firmcode, string Contact, string Mail, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PUR_OFFERVENDHEAD");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Offerref.HasValue)
                query.Eq("OFFERREF", Offerref.Value);

            if(Firmref.HasValue)
                query.Eq("FIRMREF", Firmref.Value);

            if(!string.IsNullOrWhiteSpace(Firmcode))
                query.Eq("FIRMCODE", Firmcode);

            if(!string.IsNullOrWhiteSpace(Contact))
                query.Eq("CONTACT", Contact);

            if(!string.IsNullOrWhiteSpace(Mail))
                query.Eq("MAIL", Mail);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmPurOffervendhead>();
        }

        public DataSet GetAll(int? Id, int? Offerref, int? Firmref, string Firmcode, string Contact, string Mail, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PUR_OFFERVENDHEAD");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Offerref.HasValue)
                query.Eq("OFFERREF", Offerref.Value);

            if (Firmref.HasValue)
                query.Eq("FIRMREF", Firmref.Value);

            if (!string.IsNullOrWhiteSpace(Firmcode))
                query.Eq("FIRMCODE", Firmcode);

            if (!string.IsNullOrWhiteSpace(Contact))
                query.Eq("CONTACT", Contact);

            if (!string.IsNullOrWhiteSpace(Mail))
                query.Eq("MAIL", Mail);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
