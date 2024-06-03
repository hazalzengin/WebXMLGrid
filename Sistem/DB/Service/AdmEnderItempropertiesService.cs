using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmEnderItempropertiesService : ServiceBase 
    {
        private readonly AdmEnderItempropertiesRepo _itemRepo;

        public AdmEnderItempropertiesService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmEnderItempropertiesRepo();
        } 

        public int Add(AdmEnderItemproperties item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmEnderItemproperties item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmEnderItemproperties> GetItemClass(int? Id, string EskiKod, string ErpKodu, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, EskiKod, ErpKodu, Isdel);
        }

        public DataSet GetAll(int? Id, string EskiKod, string ErpKodu, int? Isdel)
        {
            return _itemRepo.GetAll(Id, EskiKod, ErpKodu, Isdel);
        }

    }
}
