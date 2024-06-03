using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmOffercredittransService : ServiceBase 
    {
        private readonly AdmOffercredittransRepo _itemRepo;

        public AdmOffercredittransService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmOffercredittransRepo();
        } 

        public int Add(AdmOffercredittrans item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmOffercredittrans item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmOffercredittrans> GetItemClass(int? Id, int? Creditref, int? Crossref, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Creditref, Crossref, Isdel);
        }

        public DataSet GetAll(int? Id, int? Creditref, int? Crossref, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Creditref, Crossref, Isdel);
        }

    }
}
