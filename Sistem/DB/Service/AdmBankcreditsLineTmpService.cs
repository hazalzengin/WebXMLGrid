using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmBankcreditsLineTmpService : ServiceBase 
    {
        private readonly AdmBankcreditsLineTmpRepo _itemRepo;

        public AdmBankcreditsLineTmpService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmBankcreditsLineTmpRepo();
        } 

        public int Add(AdmBankcreditsLineTmp item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmBankcreditsLineTmp item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmBankcreditsLineTmp> GetItemClass(int? Id, int? Headref, int? Islemturuvalue, int? Taksitno, int? Gecengun, int? Durumuvalue, int? Isdel, int? Istransferred, int? Transferref)
        {
            return  _itemRepo.GetItemClass(Id, Headref, Islemturuvalue, Taksitno, Gecengun, Durumuvalue, Isdel, Istransferred, Transferref);
        }

        public DataSet GetAll(int? Id, int? Headref, int? Islemturuvalue, int? Taksitno, int? Gecengun, int? Durumuvalue, int? Isdel, int? Istransferred, int? Transferref)
        {
            return _itemRepo.GetAll(Id, Headref, Islemturuvalue, Taksitno, Gecengun, Durumuvalue, Isdel, Istransferred, Transferref);
        }

    }
}
