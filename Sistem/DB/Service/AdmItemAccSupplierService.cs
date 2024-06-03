using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmItemAccSupplierService : ServiceBase 
    {
        private readonly AdmItemAccSupplierRepo _itemRepo;

        public AdmItemAccSupplierService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmItemAccSupplierRepo();
        } 

        public int Add(AdmItemAccSupplier item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmItemAccSupplier item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmItemAccSupplier> GetItemClass(int? Id, int? Itemref, string Itemcode, int? Firmref, string Firmcode, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Itemref, Itemcode, Firmref, Firmcode, Isdel);
        }

        public DataSet GetAll(int? Id, int? Itemref, string Itemcode, int? Firmref, string Firmcode, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Itemref, Itemcode, Firmref, Firmcode, Isdel);
        }

    }
}
