using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class WmsPurorderService : ServiceBase 
    {
        private readonly WmsPurorderRepo _itemRepo;

        public WmsPurorderService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new WmsPurorderRepo();
        } 

        public int Add(WmsPurorder item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(WmsPurorder item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<WmsPurorder> GetItemClass(int? Id, DateTime? Date_, int? Statusref, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Date_, Statusref, Isdel);
        }

        public DataSet GetAll(int? Id, DateTime? Date_, int? Statusref, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Date_, Statusref, Isdel);
        }

    }
}
