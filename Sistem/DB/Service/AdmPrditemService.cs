using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmPrditemService : ServiceBase 
    {
        private readonly AdmPrditemRepo _itemRepo;

        public AdmPrditemService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmPrditemRepo();
        } 

        public int Add(AdmPrditem item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmPrditem item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmPrditem> GetItemClass(int? Id, int? Oprref, int? Orderref, int? Ordertype, string Itemcode, int? Isactive, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Oprref, Orderref, Ordertype, Itemcode, Isactive, Isdel);
        }

        public DataSet GetAll(int? Id, int? Oprref, int? Orderref, int? Ordertype, string Itemcode, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Oprref, Orderref, Ordertype, Itemcode, Isactive, Isdel);
        }

    }
}
