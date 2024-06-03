using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmPurDemandheadService : ServiceBase
    {
        private readonly AdmPurDemandheadRepo _itemRepo;

        public AdmPurDemandheadService(string conStr = "")
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmPurDemandheadRepo();
        }

        public int Add(AdmPurDemandhead item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmPurDemandhead item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmPurDemandhead> GetItemClass(int? Id, DateTime? Date_, DateTime? Duedate, int? Personnelref, int? Departmentref, int? Priority, int? Demandtype, string Costcenter, int? Demandstatus, int? Approvestatus, int? Isdel)
        {
            return _itemRepo.GetItemClass(Id, Date_, Duedate, Personnelref, Departmentref, Priority, Demandtype, Costcenter, Demandstatus, Approvestatus, Isdel);
        }

        public DataSet GetAll(string LANGU, int? Id, DateTime? StartDate, DateTime? EndDate, int? Personnelref, int? Departmentref, int? Priority, int? Demandtype, string Costcenter, int? Demandstatus, int? Approvestatus, int? Isdel)
        {
            return _itemRepo.GetAll(LANGU, Id, StartDate, EndDate, Personnelref, Departmentref, Priority, Demandtype, Costcenter, Demandstatus, Approvestatus, Isdel);
        }

    }
}
