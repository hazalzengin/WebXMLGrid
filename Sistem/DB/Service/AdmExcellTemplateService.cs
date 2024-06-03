using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmExcellTemplateService : ServiceBase 
    {
        private readonly AdmExcellTemplateRepo _itemRepo;

        public AdmExcellTemplateService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmExcellTemplateRepo();
        } 

        public int Add(AdmExcellTemplate item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmExcellTemplate item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmExcellTemplate> GetItemClass(int? Id, string Pagename, string Fieldname, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Pagename, Fieldname, Isdel);
        }

        public DataSet GetAll(int? Id, string Pagename, string Fieldname, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Pagename, Fieldname, Isdel);
        }

    }
}
