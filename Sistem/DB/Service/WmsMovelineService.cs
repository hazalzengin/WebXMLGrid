using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class WmsMovelineService : ServiceBase 
    {
        private readonly WmsMovelineRepo _itemRepo;

        public WmsMovelineService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new WmsMovelineRepo();
        } 

        public int Add(WmsMoveline item)
        {
            item.Isdelete = 0;
            return _itemRepo.Insert(item);
        }

        public int Update(WmsMoveline item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<WmsMoveline> GetItemClass(int? Id, int? Ficheref, int? Trcode, int? Iocode, int? Itemref, string Itemcode, int? Uomref, int? Isdelete, int? Locationref, int? Branch, int? Sourceindex, int? Istransferred, int? Llineref,String barcode, int? WmsParentref)
        {
            return  _itemRepo.GetItemClass(Id, Ficheref, Trcode, Iocode, Itemref, Itemcode, Uomref, Isdelete, Locationref, Branch, Sourceindex, Istransferred, Llineref,barcode, WmsParentref);
        }

        public DataSet GetAll(int? Id, int? Ficheref, int? Trcode, int? Iocode, int? Itemref, string Itemcode, int? Uomref, int? Isdelete, int? Locationref, int? Branch, int? Sourceindex, int? Istransferred, int? Llineref, String barcode, int? WmsParentref)
        {
            return _itemRepo.GetAll(Id, Ficheref, Trcode, Iocode, Itemref, Itemcode, Uomref, Isdelete, Locationref, Branch, Sourceindex, Istransferred, Llineref,barcode, WmsParentref);
        }

    }
}
