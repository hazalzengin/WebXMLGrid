using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmQltParamvalService : ServiceBase
    {
        private readonly AdmQltParamvalRepo _itemRepo;

        public AdmQltParamvalService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmQltParamvalRepo();
        }

        public int Add(AdmQltParamval item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmQltParamval item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmQltParamval> GetItemClass(int? Id, int? Paramref, string Code, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetItemClass(Id, Paramref, Code, Isactive, Isdel);
        }

        public DataSet GetAll(string LANGU, int? Id, int? Paramref, string Code, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetAll(LANGU, Id, Paramref, Code, Isactive, Isdel);
        }

    }
}
