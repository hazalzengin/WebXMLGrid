using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmQltParamService : ServiceBase
    {
        private readonly AdmQltParamRepo _itemRepo;

        public AdmQltParamService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmQltParamRepo();
        }

        public int Add(AdmQltParam item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmQltParam item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmQltParam> GetItemClass(int? Id, string Code, DateTime? Validfrom, DateTime? Validuntil, int? Ispur, int? Isprod, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetItemClass(Id, Code, Validfrom, Validuntil, Ispur, Isprod, Isactive, Isdel);
        }

        public DataSet GetAll(string LANGU, int? Id, string Code, DateTime? Validfrom, DateTime? Validuntil, int? Ispur, int? Isprod, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetAll( LANGU, Id, Code, Validfrom, Validuntil, Ispur, Isprod, Isactive, Isdel);
        }

    }
}
