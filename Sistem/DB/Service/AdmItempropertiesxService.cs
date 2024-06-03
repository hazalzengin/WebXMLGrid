using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmItempropertiesxService : ServiceBase 
    {
        private readonly AdmItempropertiesxRepo _itemRepo;

        public AdmItempropertiesxService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmItempropertiesxRepo();
        } 

        public int Add(AdmItempropertiesx item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmItempropertiesx item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmItempropertiesx> GetItemClass(int? Id, int? Refid)
        {
            return  _itemRepo.GetItemClass(Id, Refid);
        }

        public DataSet GetAll()
        {
            return _itemRepo.GetAll();
        }

    }
}
