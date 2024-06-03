using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmItemsRepo:BaseRepository<AdmItems> 
    {

        public List<AdmItems> GetItemClass(int? Parentref, int? Id, string Code, int? Istransferred, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ITEMS");

            if (Parentref.HasValue)
                query.Eq("PARENTREF", Parentref.Value);

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Code))
                query.Eq("CODE", Code);

            if(Istransferred.HasValue)
                query.Eq("ISTRANSFERRED", Istransferred.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmItems>();
        }

        public DataSet GetAll(int? Parentref, int? Id, string Code, int? Istransferred, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ITEMS");

            if (Parentref.HasValue)
                query.Eq("PARENTREF", Parentref.Value);

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Code))
                query.Eq("CODE", Code);

            if(Istransferred.HasValue)
                query.Eq("ISTRANSFERRED", Istransferred.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
