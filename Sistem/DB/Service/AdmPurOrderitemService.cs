using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmPurOrderitemService : ServiceBase
    {
        private readonly AdmPurOrderitemRepo _itemRepo;

        public AdmPurOrderitemService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmPurOrderitemRepo();
        }

        public int Add(AdmPurOrderitem item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmPurOrderitem item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmPurOrderitem> GetItemClass(int? Id, int? Orderref, int? Itemref, string Itemcode, string Unit, string Currency, DateTime? Duedate)
        {
            return _itemRepo.GetItemClass(Id, Orderref, Itemref, Itemcode, Unit, Currency, Duedate);
        }

        public DataSet GetAll(int? Id, int? Orderref, int? Itemref, string Itemcode, string Unit, string Currency, DateTime? Duedate)
        {
            return _itemRepo.GetAll(Id, Orderref, Itemref, Itemcode, Unit, Currency, Duedate);
        }

    }
}
