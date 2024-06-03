using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmTmzOfferitemsExcelService : ServiceBase 
    {
        private readonly AdmTmzOfferitemsExcelRepo _itemRepo;

        public AdmTmzOfferitemsExcelService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmTmzOfferitemsExcelRepo();
        } 

        public int Add(AdmTmzOfferitemsExcel item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmTmzOfferitemsExcel item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmTmzOfferitemsExcel> GetItemClass(int? Id, int? Parentref, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Parentref,  Isdel);
        }

        public DataSet GetAll(int? Id, int? Parentref, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Parentref,  Isdel);
        }

    }
}
