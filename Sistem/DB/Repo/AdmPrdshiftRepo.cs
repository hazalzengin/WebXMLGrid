using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmPrdshiftRepo:BaseRepository<AdmPrdshift> 
    {

        public List<AdmPrdshift> GetItemClass(int? Id, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PRDSHIFT");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmPrdshift>();
        }

        public DataSet GetAll(int? Id, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PRDSHIFT");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
