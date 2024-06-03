using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmWorkorderitemsService : ServiceBase
    {
        private readonly AdmWorkorderitemsRepo _itemRepo;

        public AdmWorkorderitemsService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmWorkorderitemsRepo();
        }

        public int Add(AdmWorkorderitems item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmWorkorderitems item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmWorkorderitems> GetItemClass(int? Id, int? Workorderref, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetItemClass(Id, Workorderref, Isactive, Isdel);
        }

        public DataSet GetAll(int? Workorderref, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetAll(Workorderref, Isactive, Isdel);
        }

    }
}
