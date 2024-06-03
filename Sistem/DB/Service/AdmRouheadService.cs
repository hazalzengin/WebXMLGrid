using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmRouheadService : ServiceBase 
    {
        private readonly AdmRouheadRepo _itemRepo;

        public AdmRouheadService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmRouheadRepo();
        } 

        public int Add(AdmRouhead item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmRouhead item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmRouhead> GetItemClass(int? Id, string Code, string Itemcode, int? Warehouse, int? Isactive, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Code, Itemcode, Warehouse, Isactive, Isdel);
        }

        public DataSet GetAll(string LANGU, string Code, string Itemcode, int? Warehouse, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetAll(LANGU, Code,Itemcode,Warehouse, Isactive, Isdel);
        }

    }
}
