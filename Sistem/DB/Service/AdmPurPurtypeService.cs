using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmPurPurtypeService : ServiceBase 
    {
        private readonly AdmPurPurtypeRepo _itemRepo;

        public AdmPurPurtypeService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmPurPurtypeRepo();
        } 

        public int Add(AdmPurPurtype item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmPurPurtype item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmPurPurtype> GetItemClass(int? Id, int? Purtype, int? Controlvendor, int? Designid, int? Issign, int? Signtype, int? Controllimit, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Purtype, Controlvendor, Designid, Issign, Signtype, Controllimit, Isdel);
        }

        public DataSet GetAll(int? Id, int? Purtype, int? Controlvendor, int? Designid, int? Issign, int? Signtype, int? Controllimit, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Purtype, Controlvendor, Designid, Issign, Signtype, Controllimit, Isdel);
        }

    }
}
