using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmRetailSaleitemsRepo:BaseRepository<AdmRetailSaleitems> 
    {

        public List<AdmRetailSaleitems> GetItemClass(int? Id, int? Reatilsaleref, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_RETAIL_SALEITEMS");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Reatilsaleref.HasValue)
                query.Eq("REATILSALEREF", Reatilsaleref.Value);

            if(Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmRetailSaleitems>();
        }

        public DataSet GetAll(int? Id, int? Reatilsaleref, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_RETAIL_SALEITEMS");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Reatilsaleref.HasValue)
                query.Eq("REATILSALEREF", Reatilsaleref.Value);

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);


            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
