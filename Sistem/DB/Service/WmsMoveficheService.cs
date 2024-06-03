using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class WmsMoveficheService : ServiceBase 
    {
        private readonly WmsMoveficheRepo _itemRepo;

        public WmsMoveficheService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new WmsMoveficheRepo();
        } 

        public int Add(WmsMovefiche item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(WmsMovefiche item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<WmsMovefiche> GetItemClass(int? Id, int? Trcode, int? Salestype, int? Purchasetype, int? Clientref, string Clcode, int? Isdelete, int? Istransferred, int? Lficheref, int? WmsRef)
        {
            return  _itemRepo.GetItemClass(Id, Trcode, Salestype, Purchasetype, Clientref, Clcode, Isdelete, Istransferred, Lficheref, WmsRef);
        }

        public DataSet GetAll(int? Id, int? Trcode, int? Salestype, int? Purchasetype, int? Clientref, string Clcode, int? Isdelete, int? Istransferred, int? Lficheref)
        {
            return _itemRepo.GetAll(Id, Trcode, Salestype, Purchasetype, Clientref, Clcode, Isdelete, Istransferred, Lficheref);
        }

    }
}
