using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmSysPopupcolumnService : ServiceBase 
    {
        private readonly AdmSysPopupcolumnRepo _itemRepo;

        public AdmSysPopupcolumnService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmSysPopupcolumnRepo();
        } 

        public int Add(AdmSysPopupcolumn item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmSysPopupcolumn item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmSysPopupcolumn> GetItemClass(int? Id, int? Popupref)
        {
            return  _itemRepo.GetItemClass(Id, Popupref);
        }

        public DataSet GetAll(int? Id, int? Popupref)
        {
            return _itemRepo.GetAll(Id, Popupref);
        }

    }
}
