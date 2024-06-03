using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmWaitingorderNotesService : ServiceBase 
    {
        private readonly AdmWaitingorderNotesRepo _itemRepo;

        public AdmWaitingorderNotesService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmWaitingorderNotesRepo();
        } 

        public int Add(AdmWaitingorderNotes item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmWaitingorderNotes item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmWaitingorderNotes> GetItemClass(int? Id, int? OrderlRef)
        {
            return  _itemRepo.GetItemClass(Id, OrderlRef);
        }

        public DataSet GetAll(int? Id, int? OrderlRef)
        {
            return _itemRepo.GetAll(Id, OrderlRef);
        }

    }
}
