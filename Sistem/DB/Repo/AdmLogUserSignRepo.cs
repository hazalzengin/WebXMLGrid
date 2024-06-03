using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmLogUserSignRepo:BaseRepository<AdmLogUserSign> 
    {

        public List<AdmLogUserSign> GetItemClass(int id)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_LOG_USER_SIGN");

            if (id > -1)
            {
                query.Eq("ID", id);
            }
            return query.ToDataSet().ToFrList<AdmLogUserSign>();
        }

        public DataSet GetAll()
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_LOG_USER_SIGN");
            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
