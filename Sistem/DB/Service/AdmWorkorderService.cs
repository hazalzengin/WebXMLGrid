using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmWorkorderService : ServiceBase
    {
        private readonly AdmWorkorderRepo _itemRepo;

        public AdmWorkorderService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmWorkorderRepo();
        }

        public int Add(AdmWorkorder item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmWorkorder item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmWorkorder> GetItemClass(int? Id, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetItemClass(Id, Isactive, Isdel);
        }

        public DataSet GetAll(string LANGU, int? statusref, int? Isdel)
        {
            return _itemRepo.GetAll(LANGU, statusref, Isdel);
        }

    }
}
