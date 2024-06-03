using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmEdcOffercreditRepo:BaseRepository<AdmEdcOffercredit> 
    {

        public List<AdmEdcOffercredit> GetItemClass(int? Id, int? LgClcardref, int? Status, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_EDC_OFFERCREDIT");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(LgClcardref.HasValue)
                query.Eq("LG_CLCARDREF", LgClcardref.Value);

            if(Status.HasValue)
                query.Eq("STATUS", Status.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmEdcOffercredit>();
        }

        public DataSet GetAll(int? Id, int? LgClcardref, int? Status, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_EDC_OFFERCREDIT");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(LgClcardref.HasValue)
                query.Eq("LG_CLCARDREF", LgClcardref.Value);

            if(Status.HasValue)
                query.Eq("STATUS", Status.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
