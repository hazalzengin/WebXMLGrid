using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmEdcOfferApprovalService : ServiceBase 
    {
        private readonly AdmEdcOfferApprovalRepo _itemRepo;

        public AdmEdcOfferApprovalService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmEdcOfferApprovalRepo();
        } 

        public int Add(AdmEdcOfferApproval item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmEdcOfferApproval item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmEdcOfferApproval> GetItemClass(int? Id, int? Offerref)
        {
            return  _itemRepo.GetItemClass(Id, Offerref);
        }

        public DataSet GetAll(int? Id, int? Offerref)
        {
            return _itemRepo.GetAll(Id, Offerref);
        }

    }
}
