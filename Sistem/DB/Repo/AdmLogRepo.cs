using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmLogRepo:BaseRepository<AdmLog> 
    {

        public List<AdmLog> GetItemClass(int id)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_LOG");

            if (id > -1)
            {
                query.Eq("ID", id);
            }
            return query.ToDataSet().ToFrList<AdmLog>();
        }

        public DataSet GetAll()
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_LOG");
            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
