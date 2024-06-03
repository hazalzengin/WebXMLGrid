using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmPrdpersonnelService : ServiceBase 
    {
        private readonly AdmPrdpersonnelRepo _itemRepo;

        public AdmPrdpersonnelService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmPrdpersonnelRepo();
        } 

        public int Add(AdmPrdpersonnel item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmPrdpersonnel item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmPrdpersonnel> GetItemClass(int? Id, string Code, string Workgroup, string Workcenter, int? Isactive, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Code, Workgroup, Workcenter, Isactive, Isdel);
        }

        public DataSet GetAll(int? Id, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Isactive, Isdel);
        }

    }
}
