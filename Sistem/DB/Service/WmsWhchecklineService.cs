using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class WmsWhchecklineService : ServiceBase 
    {
        private readonly WmsWhchecklineRepo _itemRepo;

        public WmsWhchecklineService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new WmsWhchecklineRepo();
        } 

        public int Add(WmsWhcheckline item)
        {
            if (!item.Changedat.HasValue) item.Changedat = DateTime.Now;
            if (!item.Createdat.HasValue) item.Createdat = DateTime.Now;
            if (!item.Iscompleted.HasValue) item.Iscompleted = 0;
            if (!item.Convfact1.HasValue) item.Convfact1 = 1;
            if (!item.Convfact2.HasValue) item.Convfact2 = 1;
            if (!item.Isnew.HasValue) item.Isnew = 0;
            if (!item.Movelineref.HasValue) item.Movelineref = 0;
            if (!item.Uomref.HasValue) item.Uomref = 0;
            return _itemRepo.Insert(item);
        }

        public int Update(WmsWhcheckline item)
        {
            if (!item.Changedat.HasValue) item.Changedat = DateTime.Now;
            item.Diffamount = item.Curramount - item.Countedamounted;
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<WmsWhcheckline> GetItemClass(int? Id, int? Headref, int? Itemref, string Itemcode, string Barcode, int? Location, int? Uomref, int? Iscompleted, int? Movelineref, int? Isnew)
        {
            return  _itemRepo.GetItemClass(Id, Headref, Itemref, Itemcode, Barcode, Location, Uomref, Iscompleted, Movelineref, Isnew);
        }

        public DataSet GetAll(int? Id, int? Headref, int? Itemref, string Itemcode, string Barcode, int? Location, int? Uomref, int? Iscompleted, int? Movelineref, int? Isnew)
        {
            return _itemRepo.GetAll(Id, Headref, Itemref, Itemcode, Barcode, Location, Uomref, Iscompleted, Movelineref, Isnew);
        }

    }
}
