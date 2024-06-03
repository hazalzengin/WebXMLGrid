using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmOffercredititemsRepo:BaseRepository<AdmOffercredititems> 
    {

        public List<AdmOffercredititems> GetItemClass(int? Id, int? Offercreditref)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_OFFERCREDITITEMS");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Offercreditref.HasValue)
                query.Eq("OFFERCREDITREF", Offercreditref.Value);

            return query.ToDataSet().ToFrList<AdmOffercredititems>();
        }

        public DataSet GetAll(int? Id, int? Offercreditref)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_OFFERCREDITITEMS");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Offercreditref.HasValue)
                query.Eq("OFFERCREDITREF", Offercreditref.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
