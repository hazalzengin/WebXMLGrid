using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class WmsTransorderheadService : ServiceBase 
    {
        private readonly WmsTransorderheadRepo _itemRepo;

        public WmsTransorderheadService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new WmsTransorderheadRepo();
        } 

        public int Add(WmsTransorderhead item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(WmsTransorderhead item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<WmsTransorderhead> GetItemClass(int? Id, DateTime? Date_, string Ficheno, int? Branch, int? Sourceindex, int? Sourcelocation, int? Destindex, int? Destlocation, int? Isdelete, int? Iscompleted, int? Wmsmoveficheref)
        {
            return  _itemRepo.GetItemClass(Id, Date_, Ficheno, Branch, Sourceindex, Sourcelocation, Destindex, Destlocation, Isdelete, Iscompleted, Wmsmoveficheref);
        }

        public DataSet GetAll(int? Id, DateTime? Date_, string Ficheno, int? Branch, int? Sourceindex, int? Sourcelocation, int? Destindex, int? Destlocation, int? Isdelete, int? Iscompleted, int? Wmsmoveficheref)
        {
            return _itemRepo.GetAll(Id, Date_, Ficheno, Branch, Sourceindex, Sourcelocation, Destindex, Destlocation, Isdelete, Iscompleted, Wmsmoveficheref);
        }

    }
}
