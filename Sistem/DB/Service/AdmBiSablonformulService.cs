using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmBiSablonformulService : ServiceBase 
    {
        private readonly AdmBiSablonformulRepo _itemRepo;

        public AdmBiSablonformulService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmBiSablonformulRepo();
        } 

        public int Add(AdmBiSablonformul item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmBiSablonformul item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmBiSablonformul> GetItemClass(int? Id, string Mastercode)
        {
            return  _itemRepo.GetItemClass(Id, Mastercode);
        }

        public DataSet GetAll(int? Id, string Mastercode)
        {
            return _itemRepo.GetAll(Id, Mastercode);
        }

    }
}
