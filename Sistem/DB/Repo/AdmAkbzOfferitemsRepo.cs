using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmAkbzOfferitemsRepo:BaseRepository<AdmAkbzOfferitems> 
    {

        public List<AdmAkbzOfferitems> GetItemClass(int? Id, int? Offerref, int? Itemkref, int? Amount, int? Unit, int? Vat, int? Vattype, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_AKBZ_OFFERITEMS");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Offerref.HasValue)
                query.Eq("OFFERREF", Offerref.Value);

            if(Itemkref.HasValue)
                query.Eq("ITEMKREF", Itemkref.Value);

            if(Amount.HasValue)
                query.Eq("AMOUNT", Amount.Value);

            if(Unit.HasValue)
                query.Eq("UNIT", Unit.Value);

            if(Vat.HasValue)
                query.Eq("VAT", Vat.Value);

            if(Vattype.HasValue)
                query.Eq("VATTYPE", Vattype.Value);

            if(Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmAkbzOfferitems>();
        }

        public DataSet GetAll(int? Offerref,int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_AKBZ_OFFERITEMS");

            if (Offerref.HasValue)
                query.Eq("OFFERREF", Offerref.Value);

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);


            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
