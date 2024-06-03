using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmDesignService : ServiceBase
    {
        private readonly AdmDesignRepo _itemRepo;

        public AdmDesignService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmDesignRepo();
        }

        public int Add(AdmDesign item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmDesign item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmDesign> GetItemClass(int? Id, string Code, string Module, string Page, string Customer, string Langu, int? Isdel)
        {
            return _itemRepo.GetItemClass(Id, Code, Module, Page, Customer, Langu, Isdel);
        }

        public DataSet GetAll(int? Id, string Code, string Module, string Page, string Customer, string Langu, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Code, Module, Page, Customer, Langu, Isdel);
        }

    }
}
