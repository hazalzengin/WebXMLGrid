using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmEdcOffercreditApprovalService : ServiceBase 
    {
        private readonly AdmEdcOffercreditApprovalRepo _itemRepo;

        public AdmEdcOffercreditApprovalService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmEdcOffercreditApprovalRepo();
        } 

        public int Add(AdmEdcOffercreditApproval item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmEdcOffercreditApproval item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmEdcOffercreditApproval> GetItemClass(int? Id, int? Offercreditref)
        {
            return  _itemRepo.GetItemClass(Id, Offercreditref);
        }

        public DataSet GetAll(int? Id, int? Offercreditref)
        {
            return _itemRepo.GetAll(Id, Offercreditref);
        }

    }
}
