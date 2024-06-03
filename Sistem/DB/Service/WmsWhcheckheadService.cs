using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class WmsWhcheckheadService : ServiceBase 
    {
        private readonly WmsWhcheckheadRepo _itemRepo;

        public WmsWhcheckheadService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new WmsWhcheckheadRepo();
        } 

        public int Add(WmsWhcheckhead item)
        {
            if (!item.Changedat.HasValue) item.Changedat = DateTime.Now;
            if (!item.Createdat.HasValue) item.Createdat = DateTime.Now;
            if (!item.Date_.HasValue) item.Date_ = DateTime.Now;
            if (!item.Iscompleted.HasValue) item.Iscompleted = 0;
            if (!item.Iscountfiche.HasValue) item.Iscountfiche = 0;
            if (!item.Isopenfiche.HasValue) item.Isopenfiche = 0;
            if (!item.Moveficheref.HasValue) item.Moveficheref = 0;
            if (!item.Willtransfer.HasValue) item.Willtransfer = 0;

            return _itemRepo.Insert(item);
        }

        public int Update(WmsWhcheckhead item)
        {
            item.Changedat = DateTime.Now;
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<WmsWhcheckhead> GetItemClass(int? Id, int? Branch, int? Sourceindex, int? Iscompleted, int? Moveficheref, int? Iscountfiche, int? Isopenfiche, int? Willtransfer,DateTime? dtDate)
        {
            return  _itemRepo.GetItemClass(Id, Branch, Sourceindex, Iscompleted, Moveficheref, Iscountfiche, Isopenfiche, Willtransfer,dtDate);
        }

        public DataSet GetAll(int? Id, int? Branch, int? Sourceindex, int? Iscompleted, int? Moveficheref, int? Iscountfiche, int? Isopenfiche, int? Willtransfer, DateTime? dtDate)
        {
            return _itemRepo.GetAll(Id, Branch, Sourceindex, Iscompleted, Moveficheref, Iscountfiche, Isopenfiche, Willtransfer,dtDate);
        }

    }
}
