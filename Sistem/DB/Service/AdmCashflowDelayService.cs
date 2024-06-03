using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmCashflowDelayService : ServiceBase
    {
        private readonly AdmCashflowDelayRepo _itemRepo;

        public AdmCashflowDelayService(string conStr = "")
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmCashflowDelayRepo();
        }

        public int Add(AdmCashflowDelay item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmCashflowDelay item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmCashflowDelay> GetItemClass(int? Id, int? Modul, int? Parentref)
        {
            return _itemRepo.GetItemClass(Id, Modul, Parentref);
        }

        public DataSet GetAll(int? Id, int? Modul, int? Parentref, DateTime? Fichedate, DateTime? Fichedate2)
        {
            return _itemRepo.GetAll(Id, Modul, Parentref, Fichedate, Fichedate2);
        }

    }
}
