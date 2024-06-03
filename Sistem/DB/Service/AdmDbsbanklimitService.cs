using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmDbsbanklimitService : ServiceBase 
    {
        private readonly AdmDbsbanklimitRepo _itemRepo;

        public AdmDbsbanklimitService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmDbsbanklimitRepo();
        } 

        public int Add(AdmDbsbanklimit item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmDbsbanklimit item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmDbsbanklimit> GetItemClass(int? Id, string Dbsclcode, string Dbsbncode, int? Dbsactive, int? Sign)
        {
            return  _itemRepo.GetItemClass(Id, Dbsclcode, Dbsbncode, Dbsactive, Sign);
        }

        public DataSet GetAll(int? Id, string Dbsclcode, string Dbsbncode, int? Dbsactive, int? Sign)
        {
            return _itemRepo.GetAll(Id, Dbsclcode, Dbsbncode, Dbsactive, Sign);
        }

    }
}
