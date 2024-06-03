using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmBankcreditsTypesService : ServiceBase 
    {
        private readonly AdmBankcreditsTypesRepo _itemRepo;

        public AdmBankcreditsTypesService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmBankcreditsTypesRepo();
        } 

        public int Add(AdmBankcreditsTypes item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmBankcreditsTypes item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmBankcreditsTypes> GetItemClass(int? Id,String code, int? Usetype, int? Credittype, int? Interesttype, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id,code, Usetype, Credittype, Interesttype,Isdel);
        }

        public DataSet GetAll(int? Id, String code, int? Usetype, int? Credittype, int? Interesttype, int? Isdel)
        {
            return _itemRepo.GetAll(Id,code, Usetype, Credittype, Interesttype,Isdel);
        }

    }
}
