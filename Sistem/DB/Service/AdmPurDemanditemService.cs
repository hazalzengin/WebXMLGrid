using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmPurDemanditemService : ServiceBase 
    {
        private readonly AdmPurDemanditemRepo _itemRepo;

        public AdmPurDemanditemService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmPurDemanditemRepo();
        } 

        public int Add(AdmPurDemanditem item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmPurDemanditem item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmPurDemanditem> GetItemClass(int? Id, int? Demandref, int? Itemref)
        {
            return  _itemRepo.GetItemClass(Id, Demandref, Itemref);
        }

        public DataSet GetAll(string LANGU, int? Id, int? Demandref, int? Itemref)
        {
            return _itemRepo.GetAll(LANGU, Id, Demandref, Itemref);
        }

    }
}
