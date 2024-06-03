using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class WmsTransorderlineService : ServiceBase 
    {
        private readonly WmsTransorderlineRepo _itemRepo;

        public WmsTransorderlineService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new WmsTransorderlineRepo();
        } 

        public int Add(WmsTransorderline item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(WmsTransorderline item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<WmsTransorderline> GetItemClass(int? Id, int? Headref, int? Itemref, string Itemcode, int? Uomref, int? Iscompleted, int? Wmsmovelineref)
        {
            return  _itemRepo.GetItemClass(Id, Headref, Itemref, Itemcode, Uomref, Iscompleted, Wmsmovelineref);
        }

        public DataSet GetAll(int? Id, int? Headref, int? Itemref, string Itemcode, int? Uomref, int? Iscompleted, int? Wmsmovelineref)
        {
            return _itemRepo.GetAll(Id, Headref, Itemref, Itemcode, Uomref, Iscompleted, Wmsmovelineref);
        }

    }
}
