using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmTmzItemMachineService : ServiceBase 
    {
        private readonly AdmTmzItemMachineRepo _itemRepo;

        public AdmTmzItemMachineService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmTmzItemMachineRepo();
        } 

        public int Add(AdmTmzItemMachine item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmTmzItemMachine item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmTmzItemMachine> GetItemClass(int? Id, string Itemcode, int? IcMakineref, string IcMakineCode, int? ArtikMakineref, int? KapakMakineref, string KapakMakineCode)
        {
            return  _itemRepo.GetItemClass(Id, Itemcode, IcMakineref, IcMakineCode, ArtikMakineref, KapakMakineref, KapakMakineCode);
        }

        public DataSet GetAll(int? Id, string Itemcode, int? IcMakineref, string IcMakineCode, int? ArtikMakineref, int? KapakMakineref, string KapakMakineCode)
        {
            return _itemRepo.GetAll(Id, Itemcode, IcMakineref, IcMakineCode, ArtikMakineref, KapakMakineref, KapakMakineCode);
        }

    }
}
