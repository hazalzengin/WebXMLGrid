using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmEdcOffercredittransService : ServiceBase 
    {
        private readonly AdmEdcOffercredittransRepo _itemRepo;

        public AdmEdcOffercredittransService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmEdcOffercredittransRepo();
        } 

        public int Add(AdmEdcOffercredittrans item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmEdcOffercredittrans item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmEdcOffercredittrans> GetItemClass(int? Id, int? Creditref, int? Offerref, int? Iocode, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Creditref, Offerref, Iocode, Isdel);
        }

        public DataSet GetAll(int? Id, int? Creditref, int? Offerref, int? Iocode, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Creditref, Offerref, Iocode, Isdel);
        }

    }
}
