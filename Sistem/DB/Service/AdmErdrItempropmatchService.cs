using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmErdrItempropmatchService : ServiceBase 
    {
        private readonly AdmErdrItempropmatchRepo _itemRepo;

        public AdmErdrItempropmatchService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmErdrItempropmatchRepo();
        } 

        public int Add(AdmErdrItempropmatch item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmErdrItempropmatch item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmErdrItempropmatch> GetItemClass(int? Id, int? Itemtype, int? Itemref, string Itemcode, int? Isactive, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Itemtype, Itemref, Itemcode, Isactive, Isdel);
        }

        public DataSet GetAll()
        {
            return _itemRepo.GetAll();
        }

    }
}
