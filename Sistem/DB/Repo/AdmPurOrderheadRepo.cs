using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmPurOrderheadRepo : BaseRepository<AdmPurOrderhead>
    {

        public List<AdmPurOrderhead> GetItemClass(int? Id, DateTime? Date_, int? Firmref, string Firmcode, string Salesmancode, string Costcenter, string Delivertype, string Paymenttype, int? Orderstatus, int? Approvestatus, int? Transferstatus, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PUR_ORDERHEAD");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Date_.HasValue)
                query.Eq("DATE_", Date_.Value);

            if (Firmref.HasValue)
                query.Eq("FIRMREF", Firmref.Value);

            if (!string.IsNullOrWhiteSpace(Firmcode))
                query.Eq("FIRMCODE", Firmcode);

            if (!string.IsNullOrWhiteSpace(Salesmancode))
                query.Eq("SALESMANCODE", Salesmancode);

            if (!string.IsNullOrWhiteSpace(Costcenter))
                query.Eq("COSTCENTER", Costcenter);

            if (!string.IsNullOrWhiteSpace(Delivertype))
                query.Eq("DELIVERTYPE", Delivertype);

            if (!string.IsNullOrWhiteSpace(Paymenttype))
                query.Eq("PAYMENTTYPE", Paymenttype);

            if (Orderstatus.HasValue)
                query.Eq("ORDERSTATUS", Orderstatus.Value);

            if (Approvestatus.HasValue)
                query.Eq("APPROVESTATUS", Approvestatus.Value);

            if (Transferstatus.HasValue)
                query.Eq("TRANSFERSTATUS", Transferstatus.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmPurOrderhead>();
        }

        public DataSet GetAll(string LANGU, int? Id, DateTime? StartDate, DateTime? EndDate, int? Firmref, string Firmcode, string Salesmancode, string Costcenter, string Delivertype, string Paymenttype, int? Orderstatus, int? Approvestatus, int? Transferstatus, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_PUR_ORDERHEAD");

            if (!string.IsNullOrWhiteSpace(LANGU))
                query.Eq("LANGU", LANGU);

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (StartDate.HasValue && EndDate.HasValue)
                query.Between("DATE_", StartDate.Value, EndDate.Value);

            if (Firmref.HasValue)
                query.Eq("FIRMREF", Firmref.Value);

            if (!string.IsNullOrWhiteSpace(Firmcode))
                query.Eq("FIRMCODE", Firmcode);

            if (!string.IsNullOrWhiteSpace(Salesmancode))
                query.Eq("SALESMANCODE", Salesmancode);

            if (!string.IsNullOrWhiteSpace(Costcenter))
                query.Eq("COSTCENTER", Costcenter);

            if (!string.IsNullOrWhiteSpace(Delivertype))
                query.Eq("DELIVERTYPE", Delivertype);

            if (!string.IsNullOrWhiteSpace(Paymenttype))
                query.Eq("PAYMENTTYPE", Paymenttype);

            if (Orderstatus.HasValue)
                query.Eq("ORDERSTATUS", Orderstatus.Value);

            if (Approvestatus.HasValue)
                query.Eq("APPROVESTATUS", Approvestatus.Value);

            if (Transferstatus.HasValue)
                query.Eq("TRANSFERSTATUS", Transferstatus.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
