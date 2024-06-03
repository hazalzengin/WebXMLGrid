using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmSysPopupheadService : ServiceBase 
    {
        private readonly AdmSysPopupheadRepo _itemRepo;

        public AdmSysPopupheadService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmSysPopupheadRepo();
        } 

        public int Add(AdmSysPopuphead item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmSysPopuphead item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmSysPopuphead> GetItemClass(int? Id, int? Columnref, string Connectionfield)
        {
            return  _itemRepo.GetItemClass(Id, Columnref, Connectionfield);
        }

        public DataSet GetAll(int? Id, int? Columnref, string Connectionfield)
        {
            return _itemRepo.GetAll(Id, Columnref, Connectionfield);
        }

    }
}
