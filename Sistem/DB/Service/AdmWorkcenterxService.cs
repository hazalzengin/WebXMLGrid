using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmWorkcenterxService : ServiceBase 
    {
        private readonly AdmWorkcenterxRepo _itemRepo;

        public AdmWorkcenterxService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmWorkcenterxRepo();
        } 

        public int Add(AdmWorkcenterx item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmWorkcenterx item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmWorkcenterx> GetItemClass(int? Id, int? Refid)
        {
            return  _itemRepo.GetItemClass(Id, Refid);
        }

        public DataSet GetAll()
        {
            return _itemRepo.GetAll();
        }

    }
}
