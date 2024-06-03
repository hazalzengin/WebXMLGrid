using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmPrdStopcodeService : ServiceBase 
    {
        private readonly AdmPrdStopcodeRepo _itemRepo;

        public AdmPrdStopcodeService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmPrdStopcodeRepo();
        } 

        public int Add(AdmPrdStopcode item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmPrdStopcode item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmPrdStopcode> GetItemClass(int? Id, string Code, string Name, int? Isactive)
        {
            return  _itemRepo.GetItemClass(Id, Code, Name, Isactive);
        }

        public DataSet GetAll(int? Id, string Code, string Name, int? Isactive)
        {
            return _itemRepo.GetAll(Id, Code, Name, Isactive);
        }

    }
}
