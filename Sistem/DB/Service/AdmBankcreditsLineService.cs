using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmBankcreditsLineService : ServiceBase 
    {
        private readonly AdmBankcreditsLineRepo _itemRepo;

        public AdmBankcreditsLineService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmBankcreditsLineRepo();
        } 

        public int Add(AdmBankcreditsLine item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmBankcreditsLine item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmBankcreditsLine> GetItemClass(int? Id, int? Headref, int? Islemturuvalue, int? Taksitno, int? Durumuvalue, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Headref, Islemturuvalue, Taksitno, Durumuvalue, Isdel);
        }

        public DataSet GetAll(int? Id, int? Headref, int? Islemturuvalue, int? Taksitno, int? Durumuvalue, int? Isdel,int? IsTransferred)
        {
            return _itemRepo.GetAll(Id, Headref, Islemturuvalue, Taksitno, Durumuvalue, Isdel,IsTransferred);
        }

    }
}
