using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmUserDashsumService : ServiceBase 
    {
        private readonly AdmUserDashsumRepo _itemRepo;

        public AdmUserDashsumService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmUserDashsumRepo();
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing == true)
            {
                _itemRepo.Dispose();
                // Managed kaynaklar icin 
            }
            base.Dispose(disposing);
            // UnManaged kaynaklar icin
        }
        public int Add(AdmUserDashsum item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmUserDashsum item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmUserDashsum> GetItemClass(int? Id, int? Userref, int? Dashsumref)
        {
            return  _itemRepo.GetItemClass(Id, Userref, Dashsumref);
        }

        public DataSet GetAll(int? Id, int? Userref, int? Dashsumref)
        {
            return _itemRepo.GetAll(Id, Userref, Dashsumref);
        }

    }
}
