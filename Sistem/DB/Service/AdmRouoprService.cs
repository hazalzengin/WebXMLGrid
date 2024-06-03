using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmRouoprService : ServiceBase 
    {
        private readonly AdmRouoprRepo _itemRepo;

        public AdmRouoprService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmRouoprRepo();
        } 

        public int Add(AdmRouopr item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmRouopr item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmRouopr> GetItemClass(int? Id, string Itemcode, string Roucode, string Code, string Oprnum, int? Workcenter, int? Isactive, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Itemcode, Roucode, Code, Oprnum, Workcenter, Isactive, Isdel);
        }

        public DataSet GetAll(string LANGU, int? Id, string Itemcode, string Roucode, string Code, string Oprnum, int? Workcenter, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetAll(LANGU,Id, Itemcode, Roucode, Code, Oprnum, Workcenter, Isactive, Isdel);
        }

    }
}
