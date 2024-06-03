using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmBankcreditsHeadService : ServiceBase 
    {
        private readonly AdmBankcreditsHeadRepo _itemRepo;

        public AdmBankcreditsHeadService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmBankcreditsHeadRepo();
        } 

        public int Add(AdmBankcreditsHead item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmBankcreditsHead item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmBankcreditsHead> GetItemClass(int? Id, int? Refno, int? Kredituruvalue, int? Faizturuvalue, int? Odemeturuvalue, int? Dovizivalue, int? Durumuvalue, int? Eximbank, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Refno, Kredituruvalue, Faizturuvalue, Odemeturuvalue, Dovizivalue, Durumuvalue, Eximbank, Isdel);
        }

        public DataSet GetAll(int? Id, int? Refno, int? Kredituruvalue, int? Faizturuvalue, int? Odemeturuvalue, int? Dovizivalue, int? Durumuvalue, int? Eximbank, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Refno, Kredituruvalue, Faizturuvalue, Odemeturuvalue, Dovizivalue, Durumuvalue, Eximbank, Isdel);
        }

        public List<AdmBankcreditsHead> GetItemClass(int? Id, int? Refno, int? Kredituruvalue, int? Faizturuvalue, int? Odemeturuvalue, int? Dovizivalue, int? Durumuvalue, int? Eximbank, int? Isdel
            , DateTime? dtBas, DateTime? dtBit,int? creditType)
        {
            return _itemRepo.GetItemClass(Id, Refno, Kredituruvalue, Faizturuvalue, Odemeturuvalue, Dovizivalue, Durumuvalue, Eximbank, Isdel,dtBas,dtBit, creditType);
        }

    }
}
