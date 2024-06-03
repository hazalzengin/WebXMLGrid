using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmQltLineService : ServiceBase 
    {
        private readonly AdmQltLineRepo _itemRepo;

        public AdmQltLineService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmQltLineRepo();
        } 

        public int Add(AdmQltLine item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmQltLine item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmQltLine> GetItemClass(int? Id, int? Headref, int? Paramref, int? Paramvalref, int? Isapproved)
        {
            return  _itemRepo.GetItemClass(Id, Headref, Paramref, Paramvalref, Isapproved);
        }

        public DataSet GetAll(int? Id, int? Headref, int? Paramref, int? Paramvalref, int? Isapproved)
        {
            return _itemRepo.GetAll(Id, Headref, Paramref, Paramvalref, Isapproved);
        }

    }
}
