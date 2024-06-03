using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmEnderAlisbirimmaliyetService : ServiceBase 
    {
        private readonly AdmEnderAlisbirimmaliyetRepo _itemRepo;

        public AdmEnderAlisbirimmaliyetService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmEnderAlisbirimmaliyetRepo();
        } 

        public int Add(AdmEnderAlisbirimmaliyet item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmEnderAlisbirimmaliyet item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmEnderAlisbirimmaliyet> GetItemClass(int? Id, string StokKodu)
        {
            return  _itemRepo.GetItemClass(Id, StokKodu);
        }

        public DataSet GetAll(int? Id, string StokKodu)
        {
            return _itemRepo.GetAll(Id, StokKodu);
        }

    }
}
