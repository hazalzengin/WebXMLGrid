using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmPurAuthgroupuserService : ServiceBase
    {
        private readonly AdmPurAuthgroupuserRepo _itemRepo;

        public AdmPurAuthgroupuserService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmPurAuthgroupuserRepo();
        }

        public int Add(AdmPurAuthgroupuser item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmPurAuthgroupuser item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmPurAuthgroupuser> GetItemClass(int? Id, int? Groupref, int? Userref, int? Isadmin, int? Showall)
        {
            return _itemRepo.GetItemClass(Id, Groupref, Userref, Isadmin, Showall);
        }

        public DataSet GetAll(int? Id, int? Groupref, int? Userref, int? Isadmin, int? Showall)
        {
            return _itemRepo.GetAll(Id, Groupref, Userref, Isadmin, Showall);
        }

    }
}
