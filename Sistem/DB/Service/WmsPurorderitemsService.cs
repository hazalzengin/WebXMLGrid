using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class WmsPurorderitemsService : ServiceBase 
    {
        private readonly WmsPurorderitemsRepo _itemRepo;

        public WmsPurorderitemsService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new WmsPurorderitemsRepo();
        } 

        public int Add(WmsPurorderitems item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(WmsPurorderitems item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<WmsPurorderitems> GetItemClass(int? Id, int? Parentref, int? Orderref, int? Orderlineref, int? Itemref, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Parentref, Orderref, Orderlineref, Itemref, Isdel);
        }

        public DataSet GetAll(int? Id, int? Parentref, int? Orderref, int? Orderlineref, int? Itemref, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Parentref, Orderref, Orderlineref, Itemref, Isdel);
        }

    }
}
