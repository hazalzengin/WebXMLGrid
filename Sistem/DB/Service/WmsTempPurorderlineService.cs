using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class WmsTempPurorderlineService : ServiceBase 
    {
        private readonly WmsTempPurorderlineRepo _itemRepo;

        public WmsTempPurorderlineService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new WmsTempPurorderlineRepo();
        } 

        public int Add(WmsTempPurorderline item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(WmsTempPurorderline item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<WmsTempPurorderline> GetItemClass(int? Id, int? Orderref, string Barcode, int? Itemref, string Itemcode, int? Branch, int? Sourceindex, int? Locationref, int? Istransferred)
        {
            return  _itemRepo.GetItemClass(Id, Orderref, Barcode, Itemref, Itemcode, Branch, Sourceindex, Locationref, Istransferred);
        }

        public DataSet GetAll(int? Id, int? Orderref, string Barcode, int? Itemref, string Itemcode, int? Branch, int? Sourceindex, int? Locationref, int? Istransferred)
        {
            return _itemRepo.GetAll(Id, Orderref, Barcode, Itemref, Itemcode, Branch, Sourceindex, Locationref, Istransferred);
        }

    }
}
