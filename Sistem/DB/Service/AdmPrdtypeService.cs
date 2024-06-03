using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmPrdtypeService : ServiceBase 
    {
        private readonly AdmPrdtypeRepo _itemRepo;

        public AdmPrdtypeService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmPrdtypeRepo();
        } 

        public int Add(AdmPrdtype item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmPrdtype item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmPrdtype> GetItemClass(int? Id, string code, int? Isactive, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, code, Isactive, Isdel);
        }

        public DataSet GetAll(string LANGU, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetAll(LANGU, Isactive, Isdel);
        }

    }
}
