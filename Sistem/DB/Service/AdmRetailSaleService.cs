using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmRetailSaleService : ServiceBase 
    {
        private readonly AdmRetailSaleRepo _itemRepo;

        public AdmRetailSaleService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmRetailSaleRepo();
        } 

        public int Add(AdmRetailSale item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmRetailSale item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmRetailSale> GetItemClass(int? Id, int? LgClcardref, int? Isactive, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, LgClcardref, Isactive, Isdel);
        }

        public DataSet GetAll(int? Id, int? LgClcardref, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetAll(Id, LgClcardref, Isactive, Isdel);
        }

    }
}
