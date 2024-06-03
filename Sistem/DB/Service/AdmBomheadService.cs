using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmBomheadService : ServiceBase
    {
        private readonly AdmBomheadRepo _itemRepo;

        public AdmBomheadService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmBomheadRepo();
        }

        public int Add(AdmBomhead item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmBomhead item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmBomhead> GetItemClass(int? Id, string itemcode, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetItemClass(Id, itemcode, Isactive, Isdel);
        }
        public List<AdmBomhead> GetItemClass(int? Id, string itemcode, int? Isactive, int? Isdel,int? bomtype,int? alternativeno)
        {
            return _itemRepo.GetItemClass(Id, itemcode, Isactive, Isdel,bomtype,alternativeno);
        }

        public DataSet GetAll(string LANGU, string itemcode, int? Id, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetAll(LANGU, itemcode, Id, Isactive, Isdel);
        }

    }
}
