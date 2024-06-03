using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmPrdshiftService : ServiceBase 
    {
        private readonly AdmPrdshiftRepo _itemRepo;

        public AdmPrdshiftService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmPrdshiftRepo();
        } 

        public int Add(AdmPrdshift item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmPrdshift item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmPrdshift> GetItemClass(int? Id, int? Isactive, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Isactive, Isdel);
        }

        public DataSet GetAll(int? Id, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Isactive, Isdel);
        }

    }
}
