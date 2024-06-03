using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmLoadingorderitemsService : ServiceBase
    {
        private readonly AdmLoadingorderitemsRepo _itemRepo;

        public AdmLoadingorderitemsService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmLoadingorderitemsRepo();
        }

        public int Add(AdmLoadingorderitems item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmLoadingorderitems item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmLoadingorderitems> GetItemClass(int? Id, int? Loadingorderref, int? Orderref, string Clcardcode, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetItemClass(Id, Loadingorderref, Orderref, Clcardcode, Isactive, Isdel);
        }

        public DataSet GetAll(int? Loadingorderref, int? Isactive, int? Isdel)
        {
            return _itemRepo.GetAll(Loadingorderref, Isactive, Isdel);
        }

    }
}
