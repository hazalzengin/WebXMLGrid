using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmZyhnOfferApprovalService : ServiceBase 
    {
        private readonly AdmZyhnOfferApprovalRepo _itemRepo;

        public AdmZyhnOfferApprovalService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmZyhnOfferApprovalRepo();
        } 

        public int Add(AdmZyhnOfferApproval item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmZyhnOfferApproval item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmZyhnOfferApproval> GetItemClass(int? Id, int? Offerref)
        {
            return  _itemRepo.GetItemClass(Id, Offerref);
        }

        public DataSet GetAll()
        {
            return _itemRepo.GetAll();
        }

    }
}
