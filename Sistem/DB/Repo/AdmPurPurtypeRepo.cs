using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmPurPurtypeRepo:BaseRepository<AdmPurPurtype> 
    {

        public List<AdmPurPurtype> GetItemClass(int? Id, int? Purtype, int? Controlvendor, int? Designid, int? Issign, int? Signtype, int? Controllimit, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PUR_PURTYPE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Purtype.HasValue)
                query.Eq("PURTYPE", Purtype.Value);

            if(Controlvendor.HasValue)
                query.Eq("CONTROLVENDOR", Controlvendor.Value);

            if(Designid.HasValue)
                query.Eq("DESIGNID", Designid.Value);

            if(Issign.HasValue)
                query.Eq("ISSIGN", Issign.Value);

            if(Signtype.HasValue)
                query.Eq("SIGNTYPE", Signtype.Value);

            if(Controllimit.HasValue)
                query.Eq("CONTROLLIMIT", Controllimit.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmPurPurtype>();
        }

        public DataSet GetAll(int? Id, int? Purtype, int? Controlvendor, int? Designid, int? Issign, int? Signtype, int? Controllimit, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PUR_PURTYPE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Purtype.HasValue)
                query.Eq("PURTYPE", Purtype.Value);

            if(Controlvendor.HasValue)
                query.Eq("CONTROLVENDOR", Controlvendor.Value);

            if(Designid.HasValue)
                query.Eq("DESIGNID", Designid.Value);

            if(Issign.HasValue)
                query.Eq("ISSIGN", Issign.Value);

            if(Signtype.HasValue)
                query.Eq("SIGNTYPE", Signtype.Value);

            if(Controllimit.HasValue)
                query.Eq("CONTROLLIMIT", Controllimit.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
