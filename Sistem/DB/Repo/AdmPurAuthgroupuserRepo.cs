using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmPurAuthgroupuserRepo:BaseRepository<AdmPurAuthgroupuser> 
    {

        public List<AdmPurAuthgroupuser> GetItemClass(int? Id, int? Groupref, int? Userref, int? Isadmin, int? Showall)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PUR_AUTHGROUPUSER");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Groupref.HasValue)
                query.Eq("GROUPREF", Groupref.Value);

            if(Userref.HasValue)
                query.Eq("USERREF", Userref.Value);

            if(Isadmin.HasValue)
                query.Eq("ISADMIN", Isadmin.Value);


            if (Showall.HasValue)
                query.Eq("SHOWALL", Showall.Value);

            return query.ToDataSet().ToFrList<AdmPurAuthgroupuser>();
        }

        public DataSet GetAll(int? Id, int? Groupref, int? Userref, int? Isadmin, int? Showall)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_PUR_AUTHGROUPUSER");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Groupref.HasValue)
                query.Eq("GROUPREF", Groupref.Value);

            if (Userref.HasValue)
                query.Eq("USERREF", Userref.Value);

            if (Isadmin.HasValue)
                query.Eq("ISADMIN", Isadmin.Value);


            if (Showall.HasValue)
                query.Eq("SHOWALL", Showall.Value);


            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
