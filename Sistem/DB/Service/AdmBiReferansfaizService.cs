using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmBiReferansfaizService : ServiceBase 
    {
        private readonly AdmBiReferansfaizRepo _itemRepo;

        public AdmBiReferansfaizService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmBiReferansfaizRepo();
        } 

        public int Add(AdmBiReferansfaiz item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmBiReferansfaiz item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmBiReferansfaiz> GetItemClass(int? Id, int? Faiztype, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Faiztype, Isdel);
        }

        public DataSet GetAll(int? Id, int? Faiztype, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Faiztype, Isdel);
        }

    }
}
