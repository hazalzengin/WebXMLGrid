using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmItemsService : ServiceBase
    {
        private readonly AdmItemsRepo _itemRepo;

        public AdmItemsService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmItemsRepo();
        }

        public int Add(AdmItems item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmItems item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmItems> GetItemClass(int? Parentref, int? Id, string Code, int? Istransferred, int? Isdel)
        {
            return _itemRepo.GetItemClass(Parentref, Id, Code, Istransferred, Isdel);
        }

        public DataSet GetAll(int? Parentref, int? Id, string Code, int? Istransferred, int? Isdel)
        {
            return _itemRepo.GetAll(Parentref, Id, Code, Istransferred, Isdel);
        }

    }
}
