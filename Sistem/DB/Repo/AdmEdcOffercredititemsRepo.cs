using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmEdcOffercredititemsRepo:BaseRepository<AdmEdcOffercredititems> 
    {

        public List<AdmEdcOffercredititems> GetItemClass(int? Id, int? Offercreditref, int? Itemref, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_EDC_OFFERCREDITITEMS");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Offercreditref.HasValue)
                query.Eq("OFFERCREDITREF", Offercreditref.Value);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmEdcOffercredititems>();
        }

        public DataSet GetAll(int? Id, int? Offercreditref, int? Itemref, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_EDC_OFFERCREDITITEMS");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Offercreditref.HasValue)
                query.Eq("OFFERCREDITREF", Offercreditref.Value);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
