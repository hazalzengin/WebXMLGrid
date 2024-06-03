using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmClcardRepo:BaseRepository<AdmClcard> 
    {

        public List<AdmClcard> GetItemClass(int? id, int? customertype, int? isactive, int? isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_CLCARD");

            if(id.HasValue)
                query.Eq("ID",id.Value);

            if(customertype.HasValue)
                query.Eq("CUSTOMERTYPE",customertype.Value);

            if(isactive.HasValue)
                query.Eq("ISACTIVE",isactive.Value);

            if(isdel.HasValue)
                query.Eq("ISDEL",isdel.Value);

            return query.ToDataSet().ToFrList<AdmClcard>();
        }

        public DataSet GetAll(int? isactive, int? isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_CLCARD");

            if (isactive.HasValue)
                query.Eq("ISACTIVE", isactive.Value);

            if (isdel.HasValue)
                query.Eq("ISDEL", isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
