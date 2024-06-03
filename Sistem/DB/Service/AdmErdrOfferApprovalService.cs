using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmErdrOfferApprovalService : ServiceBase 
    {
        private readonly AdmErdrOfferApprovalRepo _itemRepo;

        public AdmErdrOfferApprovalService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmErdrOfferApprovalRepo();
        } 

        public int Add(AdmErdrOfferApproval item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmErdrOfferApproval item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmErdrOfferApproval> GetItemClass(int? Id, int? Offerref)
        {
            return  _itemRepo.GetItemClass(Id, Offerref);
        }

        public DataSet GetAll()
        {
            return _itemRepo.GetAll();
        }

    }
}
