using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmPurAuthgroupRepo:BaseRepository<AdmPurAuthgroup> 
    {

        public List<AdmPurAuthgroup> GetItemClass(int? Id, string Groupcode)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PUR_AUTHGROUP");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Groupcode))
                query.Eq("GROUPCODE", Groupcode);


            return query.ToDataSet().ToFrList<AdmPurAuthgroup>();
        }

        public DataSet GetAll(int? Id, string Groupcode)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PUR_AUTHGROUP");
            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
