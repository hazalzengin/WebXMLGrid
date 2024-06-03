using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmBiBankaLimitleriService : ServiceBase 
    {
        private readonly AdmBiBankaLimitleriRepo _itemRepo;

        public AdmBiBankaLimitleriService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmBiBankaLimitleriRepo();
        } 

        public int Add(AdmBiBankaLimitleri item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmBiBankaLimitleri item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmBiBankaLimitleri> GetItemClass(int? Id, int? Bankref, int? Firmnr, int? Currency, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Bankref, Firmnr, Currency, Isdel);
        }

        public DataSet GetAll(int? Id, int? Bankref, int? Firmnr, int? Currency, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Bankref, Firmnr, Currency, Isdel);
        }

    }
}
