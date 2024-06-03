using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmSupportTableRepo:BaseRepository<AdmSupportTable> 
    {

        public List<AdmSupportTable> GetItemClass(int? Id, int? Menuparentref, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_SUPPORT_TABLE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Menuparentref.HasValue)
                query.Eq("MENUPARENTREF", Menuparentref.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmSupportTable>();
        }

        public DataSet GetAll(int? Id, int? Menuparentref, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_SUPPORT_TABLE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Menuparentref.HasValue)
                query.Eq("MENUPARENTREF", Menuparentref.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
