using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmEnderMikserReceteService : ServiceBase 
    {
        private readonly AdmEnderMikserReceteRepo _itemRepo;

        public AdmEnderMikserReceteService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmEnderMikserReceteRepo();
        } 

        public int Add(AdmEnderMikserRecete item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmEnderMikserRecete item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmEnderMikserRecete> GetItemClass(int? Id, string Tur, string Hamurkodu, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Tur, Hamurkodu, Isdel);
        }

        public DataSet GetAll(int? Id, string Tur, string Hamurkodu, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Tur, Hamurkodu, Isdel);
        }

    }
}
