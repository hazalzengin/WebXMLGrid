using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmBiSablonService : ServiceBase 
    {
        private readonly AdmBiSablonRepo _itemRepo;

        public AdmBiSablonService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmBiSablonRepo();
        } 

        public int Add(AdmBiSablon item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmBiSablon item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmBiSablon> GetItemClass(int? Id, string Code, int? Isactive, int? Type_)
        {
            return  _itemRepo.GetItemClass(Id, Code, Isactive, Type_);
        }

        public DataSet GetAll(int? Id, string Code, int? Isactive, int? Type_)
        {
            return _itemRepo.GetAll(Id, Code, Isactive, Type_);
        }

    }
}
