using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmPurOrderheadService : ServiceBase
    {
        private readonly AdmPurOrderheadRepo _itemRepo;

        public AdmPurOrderheadService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmPurOrderheadRepo();
        }

        public int Add(AdmPurOrderhead item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmPurOrderhead item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmPurOrderhead> GetItemClass(int? Id, DateTime? Date_, int? Firmref, string Firmcode, string Salesmancode, string Costcenter, string Delivertype, string Paymenttype, int? Orderstatus, int? Approvestatus, int? Transferstatus, int? Isdel)
        {
            return _itemRepo.GetItemClass(Id, Date_, Firmref, Firmcode, Salesmancode, Costcenter, Delivertype, Paymenttype, Orderstatus, Approvestatus, Transferstatus, Isdel);
        }

        public DataSet GetAll(string LANGU, int? Id, DateTime? StartDate, DateTime? EndDate, int? Firmref, string Firmcode, string Salesmancode, string Costcenter, string Delivertype, string Paymenttype, int? Orderstatus, int? Approvestatus, int? Transferstatus, int? Isdel)
        {
            return _itemRepo.GetAll(LANGU, Id, StartDate, EndDate, Firmref, Firmcode, Salesmancode, Costcenter, Delivertype, Paymenttype, Orderstatus, Approvestatus, Transferstatus, Isdel);
        }

    }
}
