using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmRetailSaleitemsService : ServiceBase 
    {
        private readonly AdmRetailSaleitemsRepo _itemRepo;

        public AdmRetailSaleitemsService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmRetailSaleitemsRepo();
        } 

        public int Add(AdmRetailSaleitems item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmRetailSaleitems item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmRetailSaleitems> GetItemClass(int? Id, int? Reatilsaleref, int? Isactive, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Reatilsaleref, Isactive, Isdel);
        }

        public DataSet GetAll(int? Id, int? Reatilsaleref, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Reatilsaleref, Isactive, Isdel);
        }

    }
}
