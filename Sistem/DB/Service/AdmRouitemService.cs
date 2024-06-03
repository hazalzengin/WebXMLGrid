using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmRouitemService : ServiceBase
    {
        private readonly AdmRouitemRepo _itemRepo;

        public AdmRouitemService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmRouitemRepo();
        }

        public int Add(AdmRouitem item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmRouitem item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmRouitem> GetItemClass(int? Id, string Roucode, string Oprcode, int? Itemref, string Itemcode, int? Warehouse, int? ItemType, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetItemClass(Id, Roucode, Oprcode, Itemref, Itemcode, Warehouse, ItemType, Isactive, Isdel);
        }

        public DataSet GetAll(int? Id, string Roucode, string Oprcode, int? Itemref, string Itemcode, int? Warehouse, int? ItemType, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Roucode, Oprcode, Itemref, Itemcode, Warehouse, ItemType, Isactive, Isdel);
        }

    }
}
