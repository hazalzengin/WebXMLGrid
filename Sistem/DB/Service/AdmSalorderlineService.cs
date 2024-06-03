using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmSalorderlineService : ServiceBase 
    {
        private readonly AdmSalorderlineRepo _itemRepo;

        public AdmSalorderlineService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmSalorderlineRepo();
        } 

        public int Add(AdmSalorderline item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmSalorderline item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmSalorderline> GetItemClass(int? Id, int? Headref, int? Itemref, int? Iscompleted)
        {
            return  _itemRepo.GetItemClass(Id, Headref, Itemref, Iscompleted);
        }

        public DataSet GetAll(int? Id, int? Headref, int? Itemref, int? Iscompleted)
        {
            return _itemRepo.GetAll(Id, Headref, Itemref, Iscompleted);
        }

    }
}
