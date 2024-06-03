using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmErdrOfferitemgroupNamesService : ServiceBase
    {
        private readonly AdmErdrOfferitemgroupNamesRepo _itemRepo;

        public AdmErdrOfferitemgroupNamesService(string conStr = "")
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmErdrOfferitemgroupNamesRepo();
        }

        public int Add(AdmErdrOfferitemgroupNames item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmErdrOfferitemgroupNames item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmErdrOfferitemgroupNames> GetItemClass(int? Id, string Marka, int? Isdel)
        {
            return _itemRepo.GetItemClass(Id, Marka, Isdel);
        }

        public DataSet GetAll(int? Id, string Marka, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Marka, Isdel);
        }

    }
}
