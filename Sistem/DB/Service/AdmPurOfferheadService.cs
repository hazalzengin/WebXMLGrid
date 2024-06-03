using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmPurOfferheadService : ServiceBase
    {
        private readonly AdmPurOfferheadRepo _itemRepo;

        public AdmPurOfferheadService(string conStr = "")
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmPurOfferheadRepo();
        }

        public int Add(AdmPurOfferhead item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmPurOfferhead item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmPurOfferhead> GetItemClass(int? Id, DateTime? Date_, DateTime? Duedate, int? Demandref, int? Personnelref, int? Departmentref, int? Priority, string Costcenter, int? Offerstatus, int? Approvestatus, int? Isdel)
        {
            return _itemRepo.GetItemClass(Id, Date_, Duedate, Demandref, Personnelref, Departmentref, Priority, Costcenter, Offerstatus, Approvestatus, Isdel);
        }

        public DataSet GetAll(string LANGU, int? Id, DateTime? StartDate, DateTime? EndDate , int? Demandref, int? Personnelref, int? Departmentref, int? Priority, string Costcenter, int? Offerstatus, int? Approvestatus, int? Isdel)
        {
            return _itemRepo.GetAll(LANGU, Id, StartDate, EndDate, Demandref, Personnelref, Departmentref, Priority, Costcenter, Offerstatus, Approvestatus, Isdel);
        }

    }
}
