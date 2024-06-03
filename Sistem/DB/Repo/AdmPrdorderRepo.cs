using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmPrdorderRepo:BaseRepository<AdmPrdorder> 
    {

        public List<AdmPrdorder> GetItemClass(int? Id, int? Itemlref, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PRDORDER");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Itemlref.HasValue)
                query.Eq("ITEMLREF", Itemlref.Value);

            if(Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmPrdorder>();
        }

        public DataSet GetAll(string LANGU, int? Id, int? Itemlref, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_PRDORDER");

            //if (!string.IsNullOrWhiteSpace(LANGU))
            //{
            //    query.Eq("LANGU", LANGU);
            //}
            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Itemlref.HasValue)
                query.Eq("ITEMLREF", Itemlref.Value);

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);


            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
