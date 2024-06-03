using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmEnderEkmaliyetService : ServiceBase 
    {
        private readonly AdmEnderEkmaliyetRepo _itemRepo;

        public AdmEnderEkmaliyetService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmEnderEkmaliyetRepo();
        } 

        public int Add(AdmEnderEkmaliyet item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmEnderEkmaliyet item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmEnderEkmaliyet> GetItemClass(int? Id, string Hamurkodu, string Maliyetkodu, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Hamurkodu, Maliyetkodu, Isdel);
        }

        public DataSet GetAll(int? Id, string Hamurkodu, string Maliyetkodu, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Hamurkodu, Maliyetkodu, Isdel);
        }

    }
}
