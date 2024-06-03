using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmWorkcenterxRepo:BaseRepository<AdmWorkcenterx> 
    {

        public List<AdmWorkcenterx> GetItemClass(int? Id, int? Refid)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_WORKCENTERx");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Refid.HasValue)
                query.Eq("REFID", Refid.Value);

            return query.ToDataSet().ToFrList<AdmWorkcenterx>();
        }

        public DataSet GetAll()
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_WORKCENTERx");
            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
