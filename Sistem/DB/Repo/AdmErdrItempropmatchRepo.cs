using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmErdrItempropmatchRepo:BaseRepository<AdmErdrItempropmatch> 
    {

        public List<AdmErdrItempropmatch> GetItemClass(int? Id, int? Itemtype, int? Itemref, string Itemcode, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ERDR_ITEMPROPMATCH");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Itemtype.HasValue)
                query.Eq("ITEMTYPE", Itemtype.Value);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if(!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if(Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmErdrItempropmatch>();
        }

        public DataSet GetAll()
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ERDR_ITEMPROPMATCH");
            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
