using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmPurOfferheadRepo:BaseRepository<AdmPurOfferhead> 
    {

        public List<AdmPurOfferhead> GetItemClass(int? Id, DateTime? Date_, DateTime? Duedate, int? Demandref, int? Personnelref, int? Departmentref, int? Priority, string Costcenter, int? Offerstatus, int? Approvestatus, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PUR_OFFERHEAD");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Date_.HasValue)
                query.Eq("DATE_", Date_.Value);

            if(Duedate.HasValue)
                query.Eq("DUEDATE", Duedate.Value);

            if(Demandref.HasValue)
                query.Eq("DEMANDREF", Demandref.Value);

            if(Personnelref.HasValue)
                query.Eq("PERSONNELREF", Personnelref.Value);

            if(Departmentref.HasValue)
                query.Eq("DEPARTMENTREF", Departmentref.Value);

            if(Priority.HasValue)
                query.Eq("PRIORITY", Priority.Value);

            if(!string.IsNullOrWhiteSpace(Costcenter))
                query.Eq("COSTCENTER", Costcenter);

            if(Offerstatus.HasValue)
                query.Eq("OFFERSTATUS", Offerstatus.Value);

            if(Approvestatus.HasValue)
                query.Eq("APPROVESTATUS", Approvestatus.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmPurOfferhead>();
        }

        public DataSet GetAll(string LANGU, int? Id, DateTime? StartDate, DateTime? EndDate, int? Demandref, int? Personnelref, int? Departmentref, int? Priority, string Costcenter, int? Offerstatus, int? Approvestatus, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_PUR_OFFERHEAD");

            if (!string.IsNullOrWhiteSpace(LANGU))
                query.Eq("LANGU", LANGU);

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (StartDate.HasValue && EndDate.HasValue)
                query.Between("DATE_", StartDate.Value, EndDate.Value);

            if (Demandref.HasValue)
                query.Eq("DEMANDREF", Demandref.Value);

            if (Personnelref.HasValue)
                query.Eq("PERSONNELREF", Personnelref.Value);

            if (Departmentref.HasValue)
                query.Eq("DEPARTMENTREF", Departmentref.Value);

            if (Priority.HasValue)
                query.Eq("PRIORITY", Priority.Value);

            if (!string.IsNullOrWhiteSpace(Costcenter))
                query.Eq("COSTCENTER", Costcenter);

            if (Offerstatus.HasValue)
                query.Eq("OFFERSTATUS", Offerstatus.Value);

            if (Approvestatus.HasValue)
                query.Eq("APPROVESTATUS", Approvestatus.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
