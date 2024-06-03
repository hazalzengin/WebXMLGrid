using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmSalorderheadService : ServiceBase 
    {
        private readonly AdmSalorderheadRepo _itemRepo;

        public AdmSalorderheadService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmSalorderheadRepo();
        } 

        public int Add(AdmSalorderhead item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmSalorderhead item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmSalorderhead> GetItemClass(int? Id, int? Iscompleted, int? Paymenttype)
        {
            return  _itemRepo.GetItemClass(Id, Iscompleted, Paymenttype);
        }

        public DataSet GetAll(int? Id, int? Iscompleted, int? Paymenttype)
        {
            return _itemRepo.GetAll(Id, Iscompleted, Paymenttype);
        }

    }
}
