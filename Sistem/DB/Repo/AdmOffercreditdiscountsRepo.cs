using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmOffercreditdiscountsRepo:BaseRepository<AdmOffercreditdiscounts> 
    {

        public List<AdmOffercreditdiscounts> GetItemClass(int? Id, int? Offercreditref, string Itemgroup, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_OFFERCREDITDISCOUNTS");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Offercreditref.HasValue)
                query.Eq("OFFERCREDITREF", Offercreditref.Value);

            if(!string.IsNullOrWhiteSpace(Itemgroup))
                query.Eq("ITEMGROUP", Itemgroup);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmOffercreditdiscounts>();
        }

        public DataSet GetAll(int? Id, int? Offercreditref, string Itemgroup, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_OFFERCREDITDISCOUNTS");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Offercreditref.HasValue)
                query.Eq("OFFERCREDITREF", Offercreditref.Value);

            if(!string.IsNullOrWhiteSpace(Itemgroup))
                query.Eq("ITEMGROUP", Itemgroup);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
