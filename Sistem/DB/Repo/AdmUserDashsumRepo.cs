using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmUserDashsumRepo:BaseRepository<AdmUserDashsum> 
    {

        public List<AdmUserDashsum> GetItemClass(int? Id, int? Userref, int? Dashsumref)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_USER_DASHSUM");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Userref.HasValue)
                query.Eq("USERREF", Userref.Value);

            if(Dashsumref.HasValue)
                query.Eq("DASHSUMREF", Dashsumref.Value);

            return query.ToDataSet().ToFrList<AdmUserDashsum>();
        }

        public DataSet GetAll(int? Id, int? Userref, int? Dashsumref)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_USER_DASHSUM");
            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
