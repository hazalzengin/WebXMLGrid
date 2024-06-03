using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmEdcOffercreditApprovalRepo:BaseRepository<AdmEdcOffercreditApproval> 
    {

        public List<AdmEdcOffercreditApproval> GetItemClass(int? Id, int? Offercreditref)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_EDC_OFFERCREDIT_APPROVAL");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Offercreditref.HasValue)
                query.Eq("OFFERCREDITREF", Offercreditref.Value);

            return query.ToDataSet().ToFrList<AdmEdcOffercreditApproval>();
        }

        public DataSet GetAll(int? Id, int? Offercreditref)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_EDC_OFFERCREDIT_APPROVAL");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Offercreditref.HasValue)
                query.Eq("OFFERCREDITREF", Offercreditref.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
