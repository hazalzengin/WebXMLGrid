using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmSysWebreportService : ServiceBase 
    {
        private readonly AdmSysWebreportRepo _itemRepo;

        public AdmSysWebreportService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmSysWebreportRepo();
        } 

        public int Add(AdmSysWebreport item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmSysWebreport item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmSysWebreport> GetItemClass(int? Id, String code, int? Virgul, int? Tur, int? Sira)
        {
            return  _itemRepo.GetItemClass(Id,code, Virgul, Tur, Sira);
        }

        public DataSet GetAll(int? Id, int? Virgul, int? Tur, int? Sira)
        {
            return _itemRepo.GetAll(Id, Virgul, Tur, Sira);
        }

    }
}
