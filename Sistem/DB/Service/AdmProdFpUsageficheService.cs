using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmProdFpUsageficheService : ServiceBase 
    {
        private readonly AdmProdFpUsageficheRepo _itemRepo;

        public AdmProdFpUsageficheService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmProdFpUsageficheRepo();
        } 

        public int Add(AdmProdFpUsagefiche item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmProdFpUsagefiche item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmProdFpUsagefiche> GetItemClass(int? Id, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Isdel);
        }

        public DataSet GetAll(int? Id, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Isdel);
        }

    }
}
