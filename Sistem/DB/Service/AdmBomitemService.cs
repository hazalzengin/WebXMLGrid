using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmBomitemService : ServiceBase 
    {
        private readonly AdmBomitemRepo _itemRepo;

        public AdmBomitemService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmBomitemRepo();
        } 

        public int Add(AdmBomitem item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmBomitem item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmBomitem> GetItemClass(int? Id, string bomcode, int? Isactive, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, bomcode, Isactive, Isdel);
        }

        public DataSet GetAll(string LANGU, int? Id, string bomcode, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetAll(LANGU, Id, bomcode, Isactive, Isdel);
        }

    }
}
