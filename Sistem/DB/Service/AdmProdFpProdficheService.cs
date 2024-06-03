using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmProdFpProdficheService : ServiceBase 
    {
        private readonly AdmProdFpProdficheRepo _itemRepo;

        public AdmProdFpProdficheService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmProdFpProdficheRepo();
        } 

        public int Add(AdmProdFpProdfiche item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmProdFpProdfiche item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmProdFpProdfiche> GetItemClass(int? Id, int? Itemref, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Itemref, Isdel);
        }

        public DataSet GetAll(int? Id, int? Itemref, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Itemref, Isdel);
        }

    }
}
