using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmPurDemanditemRepo:BaseRepository<AdmPurDemanditem> 
    {

        public List<AdmPurDemanditem> GetItemClass(int? Id, int? Demandref, int? Itemref)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PUR_DEMANDITEM");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Demandref.HasValue)
                query.Eq("DEMANDREF", Demandref.Value);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            return query.ToDataSet().ToFrList<AdmPurDemanditem>();
        }

        public DataSet GetAll(string LANGU, int? Id, int? Demandref, int? Itemref)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_PUR_DEMANDITEM");


            //if (!string.IsNullOrWhiteSpace(LANGU))
            //    query.Eq("LANGU", LANGU);

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Demandref.HasValue)
                query.Eq("DEMANDREF", Demandref.Value);

            if (Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
