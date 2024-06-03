using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmWorkstationService : ServiceBase 
    {
        private readonly AdmWorkstationRepo _itemRepo;

        public AdmWorkstationService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmWorkstationRepo();
        } 

        public int Add(AdmWorkstation item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmWorkstation item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmWorkstation> GetItemClass(int? Id, int? Isactive, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Isactive, Isdel);
        }

        public DataSet GetAll(string LANGU, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetAll(LANGU, Isactive, Isdel);
        }

    }
}
