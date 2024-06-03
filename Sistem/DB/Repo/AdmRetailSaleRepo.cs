using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmRetailSaleRepo:BaseRepository<AdmRetailSale> 
    {

        public List<AdmRetailSale> GetItemClass(int? Id, int? LgClcardref, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_RETAIL_SALE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(LgClcardref.HasValue)
                query.Eq("LG_CLCARDREF", LgClcardref.Value);

            if(Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmRetailSale>();
        }

        public DataSet GetAll(int? Id, int? LgClcardref, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_RETAIL_SALE");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (LgClcardref.HasValue)
                query.Eq("LG_CLCARDREF", LgClcardref.Value);

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);


            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
