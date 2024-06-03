using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmLoadingorderService : ServiceBase 
    {
        private readonly AdmLoadingorderRepo _itemRepo;

        public AdmLoadingorderService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmLoadingorderRepo();
        } 

        public int Add(AdmLoadingorder item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmLoadingorder item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmLoadingorder> GetItemClass(int? Id, int? Statusref, int? Isactive, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Statusref, Isactive, Isdel);
        }

        public DataSet GetAll(string LANGU, int? statusref, int? Isdel)
        {
            return _itemRepo.GetAll(LANGU, statusref, Isdel);
        }

    }
}
