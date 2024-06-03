using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmErdrOfferitemgroupUnitsService : ServiceBase
    {
        private readonly AdmErdrOfferitemgroupUnitsRepo _itemRepo;

        public AdmErdrOfferitemgroupUnitsService(string conStr = "")
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmErdrOfferitemgroupUnitsRepo();
        }

        public int Add(AdmErdrOfferitemgroupUnits item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmErdrOfferitemgroupUnits item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmErdrOfferitemgroupUnits> GetItemClass(int? Id, int? Orderno, int? Isdel)
        {
            return _itemRepo.GetItemClass(Id, Orderno, Isdel);
        }

        public DataSet GetAll(int? Id, int? Orderno, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Orderno, Isdel);
        }

    }
}
