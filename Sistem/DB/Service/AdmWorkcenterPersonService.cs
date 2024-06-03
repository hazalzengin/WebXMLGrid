using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmWorkcenterPersonService : ServiceBase 
    {
        private readonly AdmWorkcenterPersonRepo _itemRepo;

        public AdmWorkcenterPersonService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmWorkcenterPersonRepo();
        } 

        public int Add(AdmWorkcenterPerson item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmWorkcenterPerson item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmWorkcenterPerson> GetItemClass(int? Id, int? Workcenterref, int? Userref, int? Hasmainperson)
        {
            return  _itemRepo.GetItemClass(Id, Workcenterref, Userref, Hasmainperson);
        }

        public DataSet GetAll(int? Id, int? Workcenterref, int? Userref, int? Hasmainperson)
        {
            return _itemRepo.GetAll(Id, Workcenterref, Userref, Hasmainperson);
        }

    }
}
