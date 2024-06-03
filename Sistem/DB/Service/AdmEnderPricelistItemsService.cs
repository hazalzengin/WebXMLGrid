using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmEnderPricelistItemsService : ServiceBase 
    {
        private readonly AdmEnderPricelistItemsRepo _itemRepo;

        public AdmEnderPricelistItemsService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmEnderPricelistItemsRepo();
        } 

        public int Add(AdmEnderPricelistItems item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmEnderPricelistItems item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmEnderPricelistItems> GetItemClass(int? Id, int? Parentref, int? Itemref)
        {
            return  _itemRepo.GetItemClass(Id, Parentref, Itemref);
        }

        public DataSet GetAll(int? Id, int? Parentref, int? Itemref)
        {
            return _itemRepo.GetAll(Id, Parentref, Itemref);
        }

    }
}
