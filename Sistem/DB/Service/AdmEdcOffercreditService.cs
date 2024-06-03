using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmEdcOffercreditService : ServiceBase 
    {
        private readonly AdmEdcOffercreditRepo _itemRepo;

        public AdmEdcOffercreditService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmEdcOffercreditRepo();
        } 

        public int Add(AdmEdcOffercredit item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmEdcOffercredit item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmEdcOffercredit> GetItemClass(int? Id, int? LgClcardref, int? Status, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, LgClcardref, Status, Isdel);
        }

        public DataSet GetAll(int? Id, int? LgClcardref, int? Status, int? Isdel)
        {
            return _itemRepo.GetAll(Id, LgClcardref, Status, Isdel);
        }

    }
}
