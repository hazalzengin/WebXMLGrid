using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmModuleConfService : ServiceBase 
    {
        private readonly AdmModuleConfRepo _itemRepo;

        public AdmModuleConfService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmModuleConfRepo();
        } 

        public int Add(AdmModuleConf item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmModuleConf item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmModuleConf> GetItemClass(int? Id, string Modulecode, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Modulecode, Isdel);
        }

        public DataSet GetAll(int? Id, string Modulecode, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Modulecode, Isdel);
        }

    }
}
