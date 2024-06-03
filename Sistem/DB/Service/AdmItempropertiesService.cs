using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmItempropertiesService : ServiceBase 
    {
        private readonly AdmItempropertiesRepo _itemRepo;

        public AdmItempropertiesService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmItempropertiesRepo();
        } 

        public int Add(AdmItemproperties item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmItemproperties item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmItemproperties> GetItemClass(int? Id, string Type, int? Isactive, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Type, Isactive, Isdel);
        }

        public DataSet GetAll(int? id, string LANGU, string TYPE, int? isActive, int? isDel)
        {
            return _itemRepo.GetAll(id, LANGU, TYPE, isActive, isDel);
        }

    }
}
