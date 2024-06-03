using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmQltParamitemRepo:BaseRepository<AdmQltParamitem> 
    {

        public List<AdmQltParamitem> GetItemClass(int? Id, int? Paramref, int? Itemref, string Itemcode)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_QLT_PARAMITEM");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Paramref.HasValue)
                query.Eq("PARAMREF", Paramref.Value);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if(!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            return query.ToDataSet().ToFrList<AdmQltParamitem>();
        }

        public DataSet GetAll(int? Id, int? Paramref, int? Itemref, string Itemcode)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_QLT_PARAMITEM");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Paramref.HasValue)
                query.Eq("PARAMREF", Paramref.Value);

            if (Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if (!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
