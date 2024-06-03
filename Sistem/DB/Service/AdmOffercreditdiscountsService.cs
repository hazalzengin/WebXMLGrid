using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmOffercreditdiscountsService : ServiceBase 
    {
        private readonly AdmOffercreditdiscountsRepo _itemRepo;

        public AdmOffercreditdiscountsService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmOffercreditdiscountsRepo();
        } 

        public int Add(AdmOffercreditdiscounts item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmOffercreditdiscounts item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmOffercreditdiscounts> GetItemClass(int? Id, int? Offercreditref, string Itemgroup, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Offercreditref, Itemgroup, Isdel);
        }

        public DataSet GetAll(int? Id, int? Offercreditref, string Itemgroup, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Offercreditref, Itemgroup, Isdel);
        }

    }
}
