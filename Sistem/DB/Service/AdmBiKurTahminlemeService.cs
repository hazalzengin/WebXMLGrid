using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmBiKurTahminlemeService : ServiceBase 
    {
        private readonly AdmBiKurTahminlemeRepo _itemRepo;

        public AdmBiKurTahminlemeService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmBiKurTahminlemeRepo();
        } 

        public int Add(AdmBiKurTahminleme item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmBiKurTahminleme item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmBiKurTahminleme> GetItemClass(int? Id, int? Currencytype, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Currencytype, Isdel);
        }

        public DataSet GetAll(int? Id, int? Currencytype, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Currencytype, Isdel);
        }

    }
}
