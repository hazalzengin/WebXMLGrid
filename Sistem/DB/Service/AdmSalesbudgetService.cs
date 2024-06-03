using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmSalesbudgetService : ServiceBase 
    {
        private readonly AdmSalesbudgetRepo _itemRepo;

        public AdmSalesbudgetService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmSalesbudgetRepo();
        } 

        public int Add(AdmSalesbudget item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmSalesbudget item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmSalesbudget> GetItemClass(int? Id, string Salesmancode, string Clientcode, string Itemcode, string Firmnr, int? Type_)
        {
            return  _itemRepo.GetItemClass(Id, Salesmancode, Clientcode, Itemcode, Firmnr, Type_);
        }

        public DataSet GetAll()
        {
            return _itemRepo.GetAll();
        }

    }
}
