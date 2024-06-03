using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmWorkcenterService : ServiceBase
    {
        private readonly AdmWorkcenterRepo _itemRepo;

        public AdmWorkcenterService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmWorkcenterRepo();
        }

        public int Add(AdmWorkcenter item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmWorkcenter item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmWorkcenter> GetItemClass(int? Id, int? Workgroup, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetItemClass(Id, Workgroup, Isactive, Isdel);
        }

        public DataSet GetAll(string LANGU, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetAll(LANGU, Isactive, Isdel);
        }

    }
}
