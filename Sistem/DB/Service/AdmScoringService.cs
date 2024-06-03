using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmScoringService : ServiceBase 
    {
        private readonly AdmScoringRepo _itemRepo;

        public AdmScoringService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmScoringRepo();
        } 

        public int Add(AdmScoring item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmScoring item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmScoring> GetItemClass(int? Id, int? Clcardref, int? Invref, int? Trcode)
        {
            return  _itemRepo.GetItemClass(Id, Clcardref, Invref, Trcode);
        }

        public DataSet GetAll()
        {
            return _itemRepo.GetAll();
        }

    }
}
