using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmLogUserRepo:BaseRepository<AdmLogUser> 
    {

        public List<AdmLogUser> GetItemClass(int id)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_LOG_USER");

            if (id > -1)
            {
                query.Eq("ID", id);
            }
            return query.ToDataSet().ToFrList<AdmLogUser>();
        }

        public DataSet GetAll()
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_LOG_USER");
            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
