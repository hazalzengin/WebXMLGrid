using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmQltParamitemspektRepo:BaseRepository<AdmQltParamitemspekt> 
    {

        public List<AdmQltParamitemspekt> GetItemClass(int? Id, int? Itemref, string Itemcode, string Itemname, int? Paramref, string Paramcode, string Paramname, int? Paramvalref, string Paramvalcode, string Paramvalname)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_QLT_PARAMITEMSPEKT");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if(!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if(!string.IsNullOrWhiteSpace(Itemname))
                query.Eq("ITEMNAME", Itemname);

            if(Paramref.HasValue)
                query.Eq("PARAMREF", Paramref.Value);

            if(!string.IsNullOrWhiteSpace(Paramcode))
                query.Eq("PARAMCODE", Paramcode);

            if(!string.IsNullOrWhiteSpace(Paramname))
                query.Eq("PARAMNAME", Paramname);

            if(Paramvalref.HasValue)
                query.Eq("PARAMVALREF", Paramvalref.Value);

            if(!string.IsNullOrWhiteSpace(Paramvalcode))
                query.Eq("PARAMVALCODE", Paramvalcode);

            if(!string.IsNullOrWhiteSpace(Paramvalname))
                query.Eq("PARAMVALNAME", Paramvalname);

            return query.ToDataSet().ToFrList<AdmQltParamitemspekt>();
        }

        public DataSet GetAll(int? Id, int? Itemref, string Itemcode, string Itemname, int? Paramref, string Paramcode, string Paramname, int? Paramvalref, string Paramvalcode, string Paramvalname)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_QLT_PARAMITEMSPEKT");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if (!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if (!string.IsNullOrWhiteSpace(Itemname))
                query.Eq("ITEMNAME", Itemname);

            if (Paramref.HasValue)
                query.Eq("PARAMREF", Paramref.Value);

            if (!string.IsNullOrWhiteSpace(Paramcode))
                query.Eq("PARAMCODE", Paramcode);

            if (!string.IsNullOrWhiteSpace(Paramname))
                query.Eq("PARAMNAME", Paramname);

            if (Paramvalref.HasValue)
                query.Eq("PARAMVALREF", Paramvalref.Value);

            if (!string.IsNullOrWhiteSpace(Paramvalcode))
                query.Eq("PARAMVALCODE", Paramvalcode);

            if (!string.IsNullOrWhiteSpace(Paramvalname))
                query.Eq("PARAMVALNAME", Paramvalname);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
