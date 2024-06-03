using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmDashsumRepo:BaseRepository<AdmDashsum> 
    {

        public List<AdmDashsum> GetItemClass(int id, int active)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_DASHSUM");

            if (id > -1)
            {
                query.Eq("ID", id);
            }
            if (active > -1)
            {
                query.Eq("ISACTIVE", active);
            }
            return query.OrderBy("ORDER_NO", OrderDirection.Asc).ToDataSet().ToFrList<AdmDashsum>();
        }

        public List<AdmDashsum> GetAuthItemClass(int id,int userref ,int active)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_USER_DASHSUM");

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
            return query.OrderBy("ORDER_NO", OrderDirection.Asc).ToDataSet().ToFrList<AdmDashsum>();
        }

        public DataSet GetAll(int active)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_DASHSUM");

            if (active > -1)
            {
                query.Eq("ISACTIVE", active);
            }
            return query.OrderBy("ORDER_NO", OrderDirection.Asc).ToDataSet();
        }


    }
}
