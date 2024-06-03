using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmDbsconnectionService : ServiceBase 
    {
        private readonly AdmDbsconnectionRepo _itemRepo;

        public AdmDbsconnectionService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmDbsconnectionRepo();
        } 

        public int Add(AdmDbsconnection item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmDbsconnection item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmDbsconnection> GetItemClass(int? Id, int? Clref, int? Dbsref, int? Conref, int? Sign, int? Invoiceref)
        {
            return  _itemRepo.GetItemClass(Id, Clref, Dbsref, Conref, Sign, Invoiceref);
        }

        public DataSet GetAll(int? Id, int? Clref, int? Dbsref, int? Conref, int? Sign, int? Invoiceref)
        {
            return _itemRepo.GetAll(Id, Clref, Dbsref, Conref, Sign, Invoiceref);
        }

    }
}
