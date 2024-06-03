using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmPaylistService : ServiceBase
    {
        private readonly AdmPaylistRepo _itemRepo;

        public AdmPaylistService(string conStr = "")
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmPaylistRepo();
        }

        public int Add(AdmPaylist item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmPaylist item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmPaylist> GetItemClass(int? Id, int? Sourcetype, int? Currency, int? Status)
        {
            return _itemRepo.GetItemClass(Id, Sourcetype, Currency, Status);
        }

        public DataSet GetAll(int? Id, int? Sourcetype, int? Currency, int? Status)
        {
            return _itemRepo.GetAll(Id, Sourcetype, Currency, Status);
        }

    }
}
