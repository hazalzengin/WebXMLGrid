using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmEnderUretimmiktarService : ServiceBase 
    {
        private readonly AdmEnderUretimmiktarRepo _itemRepo;

        public AdmEnderUretimmiktarService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmEnderUretimmiktarRepo();
        } 

        public int Add(AdmEnderUretimmiktar item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmEnderUretimmiktar item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmEnderUretimmiktar> GetItemClass(int? Id, int? Year_, int? Month_)
        {
            return  _itemRepo.GetItemClass(Id, Year_, Month_);
        }

        public DataSet GetAll(int? Id, int? Year_, int? Month_)
        {
            return _itemRepo.GetAll(Id, Year_, Month_);
        }

    }
}
