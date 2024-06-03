using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmEnderMamulReceteService : ServiceBase 
    {
        private readonly AdmEnderMamulReceteRepo _itemRepo;

        public AdmEnderMamulReceteService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmEnderMamulReceteRepo();
        } 

        public int Add(AdmEnderMamulRecete item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmEnderMamulRecete item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmEnderMamulRecete> GetItemClass(int? Id, string Kodu, string Eskikodu, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Kodu, Eskikodu, Isdel);
        }

        public DataSet GetAll(int? Id, string Kodu, string Eskikodu, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Kodu, Eskikodu, Isdel);
        }

    }
}
