using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmTmzOfferitemsBookService : ServiceBase 
    {
        private readonly AdmTmzOfferitemsBookRepo _itemRepo;

        public AdmTmzOfferitemsBookService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmTmzOfferitemsBookRepo();
        } 

        public int Add(AdmTmzOfferitemsBook item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmTmzOfferitemsBook item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmTmzOfferitemsBook> GetItemClass(int? Id, int? Offerref, int? Offeritemref, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Offerref, Offeritemref, Isdel);
        }

        public DataSet GetAll(int? Id, int? Offerref, int? Offeritemref, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Offerref, Offeritemref, Isdel);
        }

    }
}
