using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmIcmalService : ServiceBase 
    {
        private readonly AdmIcmalRepo _itemRepo;

        public AdmIcmalService(string conStr)
        {

            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmIcmalRepo();
        } 

        public int Add(AdmIcmal item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmIcmal item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmIcmal> GetItemClass(int? Id, decimal? Amount, decimal? Firmamf, decimal? Depomf)
        {
            return  _itemRepo.GetItemClass(Id, Amount, Firmamf, Depomf);
        }

        public DataSet GetAll(int? Id, decimal? Amount, decimal? Firmamf, decimal? Depomf)
        {
            return _itemRepo.GetAll(Id, Amount, Firmamf, Depomf);
        }

    }
}
