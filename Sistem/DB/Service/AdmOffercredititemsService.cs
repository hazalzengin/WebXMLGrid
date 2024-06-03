using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmOffercredititemsService : ServiceBase 
    {
        private readonly AdmOffercredititemsRepo _itemRepo;

        public AdmOffercredititemsService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmOffercredititemsRepo();
        } 

        public int Add(AdmOffercredititems item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmOffercredititems item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmOffercredititems> GetItemClass(int? Id, int? Offercreditref)
        {
            return  _itemRepo.GetItemClass(Id, Offercreditref);
        }

        public DataSet GetAll(int? Id, int? Offercreditref)
        {
            return _itemRepo.GetAll(Id, Offercreditref);
        }

    }
}
