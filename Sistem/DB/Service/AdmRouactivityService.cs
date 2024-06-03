using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmRouactivityService : ServiceBase 
    {
        private readonly AdmRouactivityRepo _itemRepo;

        public AdmRouactivityService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmRouactivityRepo();
        } 

        public int Add(AdmRouactivity item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmRouactivity item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmRouactivity> GetItemClass(int? Id, int? Actunit, int? Issetup, int? Ismachine, int? Islabour, int? Actaccount, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Actunit, Issetup, Ismachine, Islabour, Actaccount, Isdel);
        }

        public DataSet GetAll(int? Id, int? Actunit, int? Issetup, int? Ismachine, int? Islabour, int? Actaccount, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Actunit, Issetup, Ismachine, Islabour, Actaccount, Isdel);
        }

    }
}
