using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmShiporderService : ServiceBase 
    {
        private readonly AdmShiporderRepo _itemRepo;

        public AdmShiporderService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmShiporderRepo();
        } 

        public int Add(AdmShiporder item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmShiporder item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmShiporder> GetItemClass(int? Id, DateTime? Date_, int? Statusref, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Date_, Statusref, Isdel);
        }

        public DataSet GetAll(int? Id, DateTime? Date_, int? Statusref, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Date_, Statusref, Isdel);
        }

    }
}
