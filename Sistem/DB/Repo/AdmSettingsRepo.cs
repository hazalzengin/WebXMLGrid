using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmSettingsRepo:BaseRepository<AdmSettings> 
    {

        public List<AdmSettings> GetItemClass(int id)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_SETTINGS");

            if (id > -1)
            {
                query.Eq("ID", id);
            }
            return query.ToDataSet().ToFrList<AdmSettings>();
        }

        public DataSet GetAll()
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_SETTINGS");
            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
