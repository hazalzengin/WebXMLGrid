using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmProdFpUsagefichelineService : ServiceBase 
    {
        private readonly AdmProdFpUsagefichelineRepo _itemRepo;

        public AdmProdFpUsagefichelineService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmProdFpUsagefichelineRepo();
        } 

        public int Add(AdmProdFpUsageficheline item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmProdFpUsageficheline item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmProdFpUsageficheline> GetItemClass(int? Id, int? Ficheref, int? Itemref, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Ficheref, Itemref, Isdel);
        }

        public DataSet GetAll(int? Id, int? Ficheref, int? Itemref, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Ficheref, Itemref, Isdel);
        }

    }
}
