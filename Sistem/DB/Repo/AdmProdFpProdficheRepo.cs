using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmProdFpProdficheRepo:BaseRepository<AdmProdFpProdfiche> 
    {

        public List<AdmProdFpProdfiche> GetItemClass(int? Id, int? Itemref, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PROD_FP_PRODFICHE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmProdFpProdfiche>();
        }

        public DataSet GetAll(int? Id, int? Itemref, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PROD_FP_PRODFICHE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
