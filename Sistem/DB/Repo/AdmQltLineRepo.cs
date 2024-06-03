using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmQltLineRepo:BaseRepository<AdmQltLine> 
    {

        public List<AdmQltLine> GetItemClass(int? Id, int? Headref, int? Paramref, int? Paramvalref, int? Isapproved)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_QLT_LINE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Headref.HasValue)
                query.Eq("HEADREF", Headref.Value);

            if(Paramref.HasValue)
                query.Eq("PARAMREF", Paramref.Value);

            if(Paramvalref.HasValue)
                query.Eq("PARAMVALREF", Paramvalref.Value);

            if(Isapproved.HasValue)
                query.Eq("ISAPPROVED", Isapproved.Value);

            return query.ToDataSet().ToFrList<AdmQltLine>();
        }

        public DataSet GetAll(int? Id, int? Headref, int? Paramref, int? Paramvalref, int? Isapproved)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_QLT_LINE");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Headref.HasValue)
                query.Eq("HEADREF", Headref.Value);

            if (Paramref.HasValue)
                query.Eq("PARAMREF", Paramref.Value);

            if (Paramvalref.HasValue)
                query.Eq("PARAMVALREF", Paramvalref.Value);

            if (Isapproved.HasValue)
                query.Eq("ISAPPROVED", Isapproved.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
