using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmEdcOffercredititemsService : ServiceBase 
    {
        private readonly AdmEdcOffercredititemsRepo _itemRepo;

        public AdmEdcOffercredititemsService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmEdcOffercredititemsRepo();
        } 

        public int Add(AdmEdcOffercredititems item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmEdcOffercredititems item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmEdcOffercredititems> GetItemClass(int? Id, int? Offercreditref, int? Itemref, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Offercreditref, Itemref, Isdel);
        }

        public DataSet GetAll(int? Id, int? Offercreditref, int? Itemref, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Offercreditref, Itemref, Isdel);
        }

    }
}
