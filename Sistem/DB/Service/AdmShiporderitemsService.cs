using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmShiporderitemsService : ServiceBase 
    {
        private readonly AdmShiporderitemsRepo _itemRepo;

        public AdmShiporderitemsService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmShiporderitemsRepo();
        } 

        public int Add(AdmShiporderitems item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmShiporderitems item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmShiporderitems> GetItemClass(int? Id, int? Parentref, int? Orderref, int? Orderitemref, int? Itemref,  int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Parentref, Orderref, Orderitemref, Itemref, Isdel);
        }

        public DataSet GetAll(int? Id, int? Parentref, int? Orderref, int? Orderitemref, int? Itemref,  int? Isdel)
        {
            return _itemRepo.GetAll(Id, Parentref, Orderref, Orderitemref, Itemref, Isdel);
        }

    }
}
