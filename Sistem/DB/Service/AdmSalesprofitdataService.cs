using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmSalesprofitdataService : ServiceBase 
    {
        private readonly AdmSalesprofitdataRepo _itemRepo;

        public AdmSalesprofitdataService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmSalesprofitdataRepo();
        } 

        public int Add(AdmSalesprofitdata item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmSalesprofitdata item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmSalesprofitdata> GetItemClass(int? Id, string Firmnr, string Period, string Clcode, string Itemcode)
        {
            return  _itemRepo.GetItemClass(Id, Firmnr, Period, Clcode, Itemcode);
        }

        public DataSet GetAll(int? Id, string Firmnr, string Period, string Clcode, string Itemcode)
        {
            return _itemRepo.GetAll(Id, Firmnr, Period, Clcode, Itemcode);
        }

    }
}
