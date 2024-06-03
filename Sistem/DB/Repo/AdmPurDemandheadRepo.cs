using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmPurDemandheadRepo:BaseRepository<AdmPurDemandhead> 
    {

        public List<AdmPurDemandhead> GetItemClass(int? Id, DateTime? Date_, DateTime? Duedate, int? Personnelref, int? Departmentref, int? Priority, int? Demandtype, string Costcenter, int? Demandstatus, int? Approvestatus, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PUR_DEMANDHEAD");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Date_.HasValue)
                query.Eq("DATE_", Date_.Value);

            if(Duedate.HasValue)
                query.Eq("DUEDATE", Duedate.Value);

            if(Personnelref.HasValue)
                query.Eq("PERSONNELREF", Personnelref.Value);

            if(Departmentref.HasValue)
                query.Eq("DEPARTMENTREF", Departmentref.Value);

            if(Priority.HasValue)
                query.Eq("PRIORITY", Priority.Value);

            if(Demandtype.HasValue)
                query.Eq("DEMANDTYPE", Demandtype.Value);

            if(!string.IsNullOrWhiteSpace(Costcenter))
                query.Eq("COSTCENTER", Costcenter);

            if(Demandstatus.HasValue)
                query.Eq("DEMANDSTATUS", Demandstatus.Value);

            if(Approvestatus.HasValue)
                query.Eq("APPROVESTATUS", Approvestatus.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmPurDemandhead>();
        }

        public DataSet GetAll(string LANGU, int? Id, DateTime? StartDate, DateTime? EndDate, int? Personnelref, int? Departmentref, int? Priority, int? Demandtype, string Costcenter, int? Demandstatus, int? Approvestatus, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_PUR_DEMANDHEAD");

            if (!string.IsNullOrWhiteSpace(LANGU))
                query.Eq("LANGU", LANGU);

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (StartDate.HasValue && EndDate.HasValue)
                query.Between("DATE_", StartDate.Value, EndDate.Value);

            if (Personnelref.HasValue)
                query.Eq("PERSONNELREF", Personnelref.Value);

            if (Departmentref.HasValue)
                query.Eq("DEPARTMENTREF", Departmentref.Value);

            if (Priority.HasValue)
                query.Eq("PRIORITY", Priority.Value);

            if (Demandtype.HasValue)
                query.Eq("DEMANDTYPE", Demandtype.Value);

            if (!string.IsNullOrWhiteSpace(Costcenter))
                query.Eq("COSTCENTER", Costcenter);

            if (Demandstatus.HasValue)
                query.Eq("DEMANDSTATUS", Demandstatus.Value);

            if (Approvestatus.HasValue)
                query.Eq("APPROVESTATUS", Approvestatus.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);
            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
