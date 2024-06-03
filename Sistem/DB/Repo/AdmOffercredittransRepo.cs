using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmOffercredittransRepo:BaseRepository<AdmOffercredittrans> 
    {

        public List<AdmOffercredittrans> GetItemClass(int? Id, int? Creditref, int? Crossref, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_OFFERCREDITTRANS");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Creditref.HasValue)
                query.Eq("CREDITREF", Creditref.Value);

            if(Crossref.HasValue)
                query.Eq("CROSSREF", Crossref.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmOffercredittrans>();
        }

        public DataSet GetAll(int? Id, int? Creditref, int? Crossref, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_OFFERCREDITTRANS");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Creditref.HasValue)
                query.Eq("CREDITREF", Creditref.Value);

            if(Crossref.HasValue)
                query.Eq("CROSSREF", Crossref.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
