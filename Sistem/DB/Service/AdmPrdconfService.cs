using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmPrdconfService : ServiceBase 
    {
        private readonly AdmPrdconfRepo _itemRepo;

        public AdmPrdconfService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmPrdconfRepo();
        } 

        public int Add(AdmPrdconf item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmPrdconf item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmPrdconf> GetItemClass(int? Id, int? Orderref, int? Oprref, int? Shiftref, int? Personelref, int? Isactive, int? Isdel, int? Transferstatus, int? Itemref, int? Confirmno, int? Confirmstatus)
        {
            return  _itemRepo.GetItemClass(Id, Orderref, Oprref, Shiftref, Personelref, Isactive, Isdel, Transferstatus, Itemref, Confirmno, Confirmstatus);
        }

        public DataSet GetAll(int? Id, int? Orderref, int? Oprref, int? Shiftref, int? Personelref, int? Isactive, int? Isdel, int? Transferstatus, int? Itemref, int? Confirmno, int? Confirmstatus)
        {
            return _itemRepo.GetAll(Id, Orderref, Oprref, Shiftref, Personelref, Isactive, Isdel, Transferstatus, Itemref, Confirmno, Confirmstatus);
        }

    }
}
