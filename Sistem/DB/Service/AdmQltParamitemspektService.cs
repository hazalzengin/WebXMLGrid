using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmQltParamitemspektService : ServiceBase 
    {
        private readonly AdmQltParamitemspektRepo _itemRepo;

        public AdmQltParamitemspektService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmQltParamitemspektRepo();
        } 

        public int Add(AdmQltParamitemspekt item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmQltParamitemspekt item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmQltParamitemspekt> GetItemClass(int? Id, int? Itemref, string Itemcode, string Itemname, int? Paramref, string Paramcode, string Paramname, int? Paramvalref, string Paramvalcode, string Paramvalname)
        {
            return  _itemRepo.GetItemClass(Id, Itemref, Itemcode, Itemname, Paramref, Paramcode, Paramname, Paramvalref, Paramvalcode, Paramvalname);
        }

        public DataSet GetAll(int? Id, int? Itemref, string Itemcode, string Itemname, int? Paramref, string Paramcode, string Paramname, int? Paramvalref, string Paramvalcode, string Paramvalname)
        {
            return _itemRepo.GetAll(Id, Itemref, Itemcode, Itemname, Paramref, Paramcode, Paramname, Paramvalref, Paramvalcode, Paramvalname);
        }

    }
}
