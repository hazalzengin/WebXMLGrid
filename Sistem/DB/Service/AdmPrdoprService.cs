using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmPrdoprService : ServiceBase
    {
        private readonly AdmPrdoprRepo _itemRepo;

        public AdmPrdoprService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmPrdoprRepo();
        }

        public int Add(AdmPrdopr item)
        {
            /*
            if (!item.Produced.HasValue) item.Produced = 0;
            if (!item.Scrapamount.HasValue) item.Scrapamount = 0;
            */
            return _itemRepo.Insert(item);
        }

        public int Update(AdmPrdopr item)
        {
            /*
            if (!item.Produced.HasValue) item.Produced = 0;
            if (!item.Scrapamount.HasValue) item.Scrapamount = 0;
            AdmPrdconfService _admPrdconfService = new AdmPrdconfService(ProgramConnection.ConStr);
            var lst = _admPrdconfService.GetItemClass(null, item.Orderref, item.Id, null, null, 1, 0, null, null, null, null);
            item.Produced = 0;
            item.Scrapamount = 0;
            foreach (var confItem in lst)
            {
                item.Produced += confItem.Produced;
                item.Scrapamount += confItem.Scrap;
            }
            */

            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmPrdopr> GetItemClass(int? Id, int? Type, string Oprnum, int? Orderref,  string Itemcode, int? Warehouse, int? Workcenter, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetItemClass(Id, Type, Oprnum, Orderref, Itemcode, Warehouse, Workcenter, Isactive, Isdel);
        }

        public DataSet GetAll(int? Id, int? Type, string Oprnum, int? Orderref, string Itemcode, int? Warehouse, int? Workcenter, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Type, Oprnum, Orderref, Itemcode, Warehouse, Workcenter, Isactive, Isdel);
        }

    }
}
