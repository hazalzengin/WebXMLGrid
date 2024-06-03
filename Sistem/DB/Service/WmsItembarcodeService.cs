using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class WmsItembarcodeService : ServiceBase 
    {
        private readonly WmsItembarcodeRepo _itemRepo;

        public WmsItembarcodeService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new WmsItembarcodeRepo();
        } 

        public int Add(WmsItembarcode item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(WmsItembarcode item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<WmsItembarcode> GetItemClass(int? Id, string Barcode, int? Itemref, string Itemcode, int? Uomref)
        {
            return  _itemRepo.GetItemClass(Id, Barcode, Itemref, Itemcode, Uomref);
        }

        public DataSet GetAll(int? Id, string Barcode, int? Itemref, string Itemcode, int? Uomref)
        {
            return _itemRepo.GetAll(Id, Barcode, Itemref, Itemcode, Uomref);
        }

    }
}
