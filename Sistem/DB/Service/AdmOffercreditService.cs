using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmOffercreditService : ServiceBase 
    {
        private readonly AdmOffercreditRepo _itemRepo;

        public AdmOffercreditService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmOffercreditRepo();
        } 

        public int Add(AdmOffercredit item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmOffercredit item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmOffercredit> GetItemClass(int? Id, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Isdel);
        }

        public DataSet GetAll(int? Id, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Isdel);
        }

    }
}
