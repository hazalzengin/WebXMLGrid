using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmSysPopupheadRepo:BaseRepository<AdmSysPopuphead> 
    {

        public List<AdmSysPopuphead> GetItemClass(int? Id, int? Columnref, string Connectionfield)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_SYS_POPUPHEAD");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Columnref.HasValue)
                query.Eq("COLUMNREF", Columnref.Value);

            if(!string.IsNullOrWhiteSpace(Connectionfield))
                query.Eq("CONNECTIONFIELD", Connectionfield);

            return query.ToDataSet().ToFrList<AdmSysPopuphead>();
        }

        public DataSet GetAll(int? Id, int? Columnref, string Connectionfield)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_SYS_POPUPHEAD");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Columnref.HasValue)
                query.Eq("COLUMNREF", Columnref.Value);

            if(!string.IsNullOrWhiteSpace(Connectionfield))
                query.Eq("CONNECTIONFIELD", Connectionfield);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
