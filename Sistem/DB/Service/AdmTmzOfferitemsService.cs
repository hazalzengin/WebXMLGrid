using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmTmzOfferitemsService : ServiceBase 
    {
        private readonly AdmTmzOfferitemsRepo _itemRepo;

        public AdmTmzOfferitemsService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmTmzOfferitemsRepo();
        } 

        public int Add(AdmTmzOfferitems item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmTmzOfferitems item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmTmzOfferitems> GetItemClass(int? Id, int? Parentref, int? Itemgroupref, int? Isatlasitem, int? Itemref, String itemcode,int? isCurrent,int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Parentref, Itemgroupref, Isatlasitem, Itemref,itemcode,isCurrent, Isdel);
        }

        public DataSet GetAll(int? Id, int? Parentref, int? Itemgroupref, int? Isatlasitem, int? Itemref, String itemcode, int? isCurrent, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Parentref, Itemgroupref, Isatlasitem, Itemref, itemcode,isCurrent,Isdel);
        }

    }
}
