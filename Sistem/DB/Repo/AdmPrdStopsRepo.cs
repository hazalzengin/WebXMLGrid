using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmPrdStopsRepo:BaseRepository<AdmPrdStops> 
    {

        public List<AdmPrdStops> GetItemClass(int? Id, int? Stopcoderef, int? Prodref, int? Prodacceptref)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PRD_STOPS");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Stopcoderef.HasValue)
                query.Eq("STOPCODEREF", Stopcoderef.Value);

            if(Prodref.HasValue)
                query.Eq("PRODREF", Prodref.Value);

            if(Prodacceptref.HasValue)
                query.Eq("PRODACCEPTREF", Prodacceptref.Value);

            return query.ToDataSet().ToFrList<AdmPrdStops>();
        }

        public DataSet GetAll(int? Id, int? Stopcoderef, int? Prodref, int? Prodacceptref)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_PRD_STOPS");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Stopcoderef.HasValue)
                query.Eq("STOPCODEREF", Stopcoderef.Value);

            if (Prodref.HasValue)
                query.Eq("PRODREF", Prodref.Value);

            if (Prodacceptref.HasValue)
                query.Eq("PRODACCEPTREF", Prodacceptref.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
