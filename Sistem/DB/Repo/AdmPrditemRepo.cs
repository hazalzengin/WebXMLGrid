using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmPrditemRepo:BaseRepository<AdmPrditem> 
    {

        public List<AdmPrditem> GetItemClass(int? Id, int? Oprref, int? Orderref, int? Ordertype, string Itemcode, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PRDITEM");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Oprref.HasValue)
                query.Eq("OPRREF", Oprref.Value);

            if (Orderref.HasValue)
                query.Eq("ORDERREF", Orderref.Value);

            if(Ordertype.HasValue)
                query.Eq("ORDERTYPE", Ordertype.Value);

            if(!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if(Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmPrditem>();
        }

        public DataSet GetAll(int? Id, int? Oprref, int? Orderref, int? Ordertype, string Itemcode, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_PRDITEM");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Oprref.HasValue)
                query.Eq("OPRREF", Oprref.Value);

            if (Orderref.HasValue)
                query.Eq("ORDERREF", Orderref.Value);

            if (Ordertype.HasValue)
                query.Eq("ORDERTYPE", Ordertype.Value);

            if (!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);


            return query.OrderBy("ID", OrderDirection.Asc).ToDataSet();
        }


    }
}
