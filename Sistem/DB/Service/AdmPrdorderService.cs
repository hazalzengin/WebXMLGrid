using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmPrdorderService : ServiceBase
    {
        private readonly AdmPrdorderRepo _itemRepo;

        public AdmPrdorderService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmPrdorderRepo();
        }

        public int Add(AdmPrdorder item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmPrdorder item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmPrdorder> GetItemClass(int? Id, int? Itemlref, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetItemClass(Id, Itemlref, Isactive, Isdel);
        }

        public DataSet GetAll(string LANGU, int? Id, int? Itemlref, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetAll(LANGU, Id, Itemlref, Isactive, Isdel);
        }

    }
}
