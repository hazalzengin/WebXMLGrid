using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmRouactivityRepo:BaseRepository<AdmRouactivity> 
    {

        public List<AdmRouactivity> GetItemClass(int? Id, int? Actunit, int? Issetup, int? Ismachine, int? Islabour, int? Actaccount, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ROUACTIVITY");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Actunit.HasValue)
                query.Eq("ACTUNIT", Actunit.Value);

            if(Issetup.HasValue)
                query.Eq("ISSETUP", Issetup.Value);

            if(Ismachine.HasValue)
                query.Eq("ISMACHINE", Ismachine.Value);

            if(Islabour.HasValue)
                query.Eq("ISLABOUR", Islabour.Value);

            if(Actaccount.HasValue)
                query.Eq("ACTACCOUNT", Actaccount.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmRouactivity>();
        }

        public DataSet GetAll(int? Id, int? Actunit, int? Issetup, int? Ismachine, int? Islabour, int? Actaccount, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ROUACTIVITY");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Actunit.HasValue)
                query.Eq("ACTUNIT", Actunit.Value);

            if(Issetup.HasValue)
                query.Eq("ISSETUP", Issetup.Value);

            if(Ismachine.HasValue)
                query.Eq("ISMACHINE", Ismachine.Value);

            if(Islabour.HasValue)
                query.Eq("ISLABOUR", Islabour.Value);

            if(Actaccount.HasValue)
                query.Eq("ACTACCOUNT", Actaccount.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
