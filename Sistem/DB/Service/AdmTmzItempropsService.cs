using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmTmzItempropsService : ServiceBase 
    {
        private readonly AdmTmzItempropsRepo _itemRepo;

        public AdmTmzItempropsService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmTmzItempropsRepo();
        } 

        public int Add(AdmTmzItemprops item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmTmzItemprops item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmTmzItemprops> GetItemClass(int? Id, string Stype, string Stext, int? Isactive, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Stype, Stext, Isactive, Isdel);
        }

        public DataSet GetAll(int? Id, string Stype, string Stext, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Stype, Stext, Isactive, Isdel);
        }

    }
}
