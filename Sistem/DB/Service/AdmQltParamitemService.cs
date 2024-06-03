using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmQltParamitemService : ServiceBase 
    {
        private readonly AdmQltParamitemRepo _itemRepo;

        public AdmQltParamitemService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmQltParamitemRepo();
        } 

        public int Add(AdmQltParamitem item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmQltParamitem item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmQltParamitem> GetItemClass(int? Id, int? Paramref, int? Itemref, string Itemcode)
        {
            return  _itemRepo.GetItemClass(Id, Paramref, Itemref, Itemcode);
        }

        public DataSet GetAll(int? Id, int? Paramref, int? Itemref, string Itemcode)
        {
            return _itemRepo.GetAll(Id, Paramref, Itemref, Itemcode);
        }

    }
}
