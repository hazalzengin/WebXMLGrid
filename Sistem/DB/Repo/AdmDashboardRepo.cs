using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmDashboardRepo : BaseRepository<AdmDashboard>
    {

        public List<AdmDashboard> GetItemClass(int id, int active)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_DASHBOARD");

            if (id > -1)
            {
                query.Eq("ID", id);
            }
            if (active > -1)
            {
                query.Eq("ISACTIVE", active);
            }
            return query.OrderBy("ORDER_NO", OrderDirection.Asc).ToDataSet().ToFrList<AdmDashboard>();
        }

        public List<AdmDashboard> GetAuthItemClass(int id, int userref, int active)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_USER_DASHBOARD");

            if (id > -1)
            {
                query.Eq("ID", id);
            }
            if (userref > -1)
            {
                query.Eq("USERREF", userref);
            }
            if (active > -1)
            {
                query.Eq("ISACTIVE", active);
            }
            return query.OrderBy("ORDER_NO", OrderDirection.Asc).ToDataSet().ToFrList<AdmDashboard>();
        }

        public DataSet GetAll(int active)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_DASHBOARD");

            if (active > -1)
            {
                query.Eq("ISACTIVE", active);
            }
            return query.OrderBy("ORDER_NO", OrderDirection.Asc).ToDataSet();
        }


    }
}
