using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmBiSabloncodeService : ServiceBase 
    {
        private readonly AdmBiSabloncodeRepo _itemRepo;

        public AdmBiSabloncodeService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmBiSabloncodeRepo();
        } 

        public int Add(AdmBiSabloncode item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmBiSabloncode item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmBiSabloncode> GetItemClass(int? Id, string Mastercode, string Code, int? Isactive,String orderBy)
        {
            return  _itemRepo.GetItemClass(Id, Mastercode, Code, Isactive,orderBy);
        }

        public DataSet GetAll(int? Id, string Mastercode, string Code, int? Isactive)
        {
            return _itemRepo.GetAll(Id, Mastercode, Code, Isactive);
        }

    }
}
