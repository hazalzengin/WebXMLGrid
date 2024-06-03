using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmClcardService : ServiceBase 
    {
        private readonly AdmClcardRepo _itemRepo;

        public AdmClcardService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmClcardRepo();
        } 

        public int Add(AdmClcard item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmClcard item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmClcard> GetItemClass(int? id, int? customertype, int? isactive, int? isdel)
        {
            return  _itemRepo.GetItemClass(id, customertype, isactive, isdel);
        }

        public DataSet GetAll(int? isactive, int? isdel)
        {
            return _itemRepo.GetAll(isactive, isdel);
        }

    }
}
