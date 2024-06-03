using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmTmzItempropsRepo:BaseRepository<AdmTmzItemprops> 
    {

        public List<AdmTmzItemprops> GetItemClass(int? Id, string Stype, string Stext, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_TMZ_ITEMPROPS");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Stype))
                query.Eq("STYPE", Stype);

            if(!string.IsNullOrWhiteSpace(Stext))
                query.Eq("STEXT", Stext);

            if(Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmTmzItemprops>();
        }

        public DataSet GetAll(int? Id, string Stype, string Stext, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_TMZ_ITEMPROPS");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Stype))
                query.Eq("STYPE", Stype);

            if(!string.IsNullOrWhiteSpace(Stext))
                query.Eq("STEXT", Stext);

            if(Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
