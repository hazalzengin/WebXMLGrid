using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmWaitingorderNotesRepo:BaseRepository<AdmWaitingorderNotes> 
    {

        public List<AdmWaitingorderNotes> GetItemClass(int? Id, int? OrderlRef)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_WAITINGORDER_NOTES");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(OrderlRef.HasValue)
                query.Eq("ORDERL_REF", OrderlRef.Value);

            return query.ToDataSet().ToFrList<AdmWaitingorderNotes>();
        }

        public DataSet GetAll(int? Id, int? OrderlRef)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_WAITINGORDER_NOTES");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(OrderlRef.HasValue)
                query.Eq("ORDERL_REF", OrderlRef.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
