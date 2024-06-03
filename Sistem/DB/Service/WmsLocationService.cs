using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class WmsLocationService : ServiceBase
    {
        private readonly WmsLocationRepo _itemRepo;

        public WmsLocationService(string conStr = "")
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new WmsLocationRepo();
        }

        public int Add(WmsLocation item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(WmsLocation item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<WmsLocation> GetItemClass(int? Id, string Code, string Barcode, int? Branch, int? Sourceindex, int? Ispurchasearea, int? Isshippingearea, int? Isprodearea, int? Isblocked)
        {
            return _itemRepo.GetItemClass(Id, Code, Barcode, Branch, Sourceindex, Ispurchasearea, Isshippingearea, Isprodearea, Isblocked);
        }

        public DataSet GetAll(int? Id, string Code, string Barcode, int? Branch, int? Sourceindex, int? Ispurchasearea, int? Isshippingearea, int? Isblocked)
        {
            return _itemRepo.GetAll(Id, Code, Barcode, Branch, Sourceindex, Ispurchasearea, Isshippingearea, Isblocked);
        }

    }
}
