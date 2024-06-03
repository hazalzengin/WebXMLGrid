using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmBiSablonresultService : ServiceBase 
    {
        private readonly AdmBiSablonresultRepo _itemRepo;

        public AdmBiSablonresultService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmBiSablonresultRepo();
        } 

        public int Add(AdmBiSablonresult item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmBiSablonresult item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmBiSablonresult> GetItemClass(int? Id, string Mastercode, string Code)
        {
            return  _itemRepo.GetItemClass(Id, Mastercode, Code);
        }

        public DataSet GetAll(int? Id, string Mastercode, string Code)
        {
            return _itemRepo.GetAll(Id, Mastercode, Code);
        }

    }
}
