using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmPrdoprRepo:BaseRepository<AdmPrdopr> 
    {

        public List<AdmPrdopr> GetItemClass(int? Id, int? Type, string Oprnum, int? Orderref, string Itemcode, int? Warehouse, int? Workcenter, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PRDOPR");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Oprnum))
                query.Eq("OPRNUM", Oprnum);

            if (Orderref.HasValue)
                query.Eq("ORDERREF", Orderref);

            if (Type.HasValue)
                query.Eq("TYPE", Type.Value);

            //if (Ordertype.HasValue)
            //    query.Eq("ORDERTYPE", Ordertype.Value);

            if(!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if(Warehouse.HasValue)
                query.Eq("WAREHOUSE", Warehouse.Value);

            if(Workcenter.HasValue)
                query.Eq("WORKCENTER", Workcenter.Value);

            if(Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("OPRNUM",OrderDirection.Asc).ToDataSet().ToFrList<AdmPrdopr>();
        }

        public DataSet GetAll(int? Id, int? Type, string Oprnum, int? Orderref, string Itemcode, int? Warehouse, int? Workcenter, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_PRDOPR");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (!string.IsNullOrWhiteSpace(Oprnum))
                query.Eq("OPRNUM", Oprnum);

            if (Orderref.HasValue)
                query.Eq("ORDERREF", Orderref);

            if (Type.HasValue)
                query.Eq("TYPE", Type.Value);

            //if (Ordertype.HasValue)
            //    query.Eq("ORDERTYPE", Ordertype.Value);

            if (!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if (Warehouse.HasValue)
                query.Eq("WAREHOUSE", Warehouse.Value);

            if (Workcenter.HasValue)
                query.Eq("WORKCENTER", Workcenter.Value);

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);
            return query.OrderBy("OPRNUM", OrderDirection.Asc).OrderBy("ID", OrderDirection.Asc).ToDataSet();
        }


    }
}
