using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmSysReportcolumnRepo:BaseRepository<AdmSysReportcolumn> 
    {

        public List<AdmSysReportcolumn> GetItemClass(int? Id, int? Headref, int? Columnorder, int? Type_, int? Isid, int? Hassubtotal, int? Subtotaltype, int? Visible, int? Cansort, int? Canfilter, int? Hasdetailpopup)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_SYS_REPORTCOLUMN");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Headref.HasValue)
                query.Eq("HEADREF", Headref.Value);

            if(Columnorder.HasValue)
                query.Eq("COLUMNORDER", Columnorder.Value);

            if(Type_.HasValue)
                query.Eq("TYPE_", Type_.Value);

            if(Isid.HasValue)
                query.Eq("ISID", Isid.Value);

            if(Hassubtotal.HasValue)
                query.Eq("HASSUBTOTAL", Hassubtotal.Value);

            if(Subtotaltype.HasValue)
                query.Eq("SUBTOTALTYPE", Subtotaltype.Value);

            if(Visible.HasValue)
                query.Eq("VISIBLE", Visible.Value);

            if(Cansort.HasValue)
                query.Eq("CANSORT", Cansort.Value);

            if(Canfilter.HasValue)
                query.Eq("CANFILTER", Canfilter.Value);

            if(Hasdetailpopup.HasValue)
                query.Eq("HASDETAILPOPUP", Hasdetailpopup.Value);

            return query.OrderBy("COLUMNORDER", OrderDirection.Asc).ToDataSet().ToFrList<AdmSysReportcolumn>();
        }

        public DataSet GetAll(int? Id, int? Headref, int? Columnorder, int? Type_, int? Isid, int? Hassubtotal, int? Subtotaltype, int? Visible, int? Cansort, int? Canfilter, int? Hasdetailpopup)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_SYS_REPORTCOLUMN");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Headref.HasValue)
                query.Eq("HEADREF", Headref.Value);

            if(Columnorder.HasValue)
                query.Eq("COLUMNORDER", Columnorder.Value);

            if(Type_.HasValue)
                query.Eq("TYPE_", Type_.Value);

            if(Isid.HasValue)
                query.Eq("ISID", Isid.Value);

            if(Hassubtotal.HasValue)
                query.Eq("HASSUBTOTAL", Hassubtotal.Value);

            if(Subtotaltype.HasValue)
                query.Eq("SUBTOTALTYPE", Subtotaltype.Value);

            if(Visible.HasValue)
                query.Eq("VISIBLE", Visible.Value);

            if(Cansort.HasValue)
                query.Eq("CANSORT", Cansort.Value);

            if(Canfilter.HasValue)
                query.Eq("CANFILTER", Canfilter.Value);

            if(Hasdetailpopup.HasValue)
                query.Eq("HASDETAILPOPUP", Hasdetailpopup.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
