using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmPrdStopsService : ServiceBase 
    {
        private readonly AdmPrdStopsRepo _itemRepo;

        public AdmPrdStopsService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmPrdStopsRepo();
        } 

        public int Add(AdmPrdStops item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmPrdStops item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmPrdStops> GetItemClass(int? Id, int? Stopcoderef, int? Prodref, int? Prodacceptref)
        {
            return  _itemRepo.GetItemClass(Id, Stopcoderef, Prodref, Prodacceptref);
        }

        public DataSet GetAll(int? Id, int? Stopcoderef, int? Prodref, int? Prodacceptref)
        {
            return _itemRepo.GetAll(Id, Stopcoderef, Prodref, Prodacceptref);
        }

    }
}
