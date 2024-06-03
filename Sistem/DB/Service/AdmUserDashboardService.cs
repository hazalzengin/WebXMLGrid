using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmUserDashboardService : ServiceBase 
    {
        private readonly AdmUserDashboardRepo _itemRepo;

        public AdmUserDashboardService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmUserDashboardRepo();
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
        public int Add(AdmUserDashboard item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmUserDashboard item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmUserDashboard> GetItemClass(int? Id, int? Userref, int? Dashboardref)
        {
            return  _itemRepo.GetItemClass(Id, Userref, Dashboardref);
        }

        public DataSet GetAll(int? Id, int? Userref, int? Dashboardref)
        {
            return _itemRepo.GetAll(Id, Userref, Dashboardref);
        }

    }
}
