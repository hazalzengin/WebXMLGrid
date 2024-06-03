using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmDepartmentService : ServiceBase
    {
        private readonly AdmDepartmentRepo _itemRepo;

        public AdmDepartmentService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmDepartmentRepo();
        }

        public int Add(AdmDepartment item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmDepartment item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmDepartment> GetItemClass(int? Id, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetItemClass(Id, Isactive, Isdel);
        }

        public DataSet GetAll(int? Id, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Isactive, Isdel);
        }

    }
}
