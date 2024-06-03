using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmSupportTableService : ServiceBase 
    {
        private readonly AdmSupportTableRepo _itemRepo;

        public AdmSupportTableService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmSupportTableRepo();
        } 

        public int Add(AdmSupportTable item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmSupportTable item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmSupportTable> GetItemClass(int? Id, int? Menuparentref, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Menuparentref, Isdel);
        }

        public DataSet GetAll(int? Id, int? Menuparentref, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Menuparentref, Isdel);
        }

    }
}
