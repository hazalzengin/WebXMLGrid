using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmUserDashboardRepo:BaseRepository<AdmUserDashboard> 
    {

        public List<AdmUserDashboard> GetItemClass(int? Id, int? Userref, int? Dashboardref)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_USER_DASHBOARD");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Userref.HasValue)
                query.Eq("USERREF", Userref.Value);

            if(Dashboardref.HasValue)
                query.Eq("DASHBOARDREF", Dashboardref.Value);

            return query.ToDataSet().ToFrList<AdmUserDashboard>();
        }

        public DataSet GetAll(int? Id, int? Userref, int? Dashboardref)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_USER_DASHBOARD");
            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
