using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmScoringRepo:BaseRepository<AdmScoring> 
    {

        public List<AdmScoring> GetItemClass(int? Id, int? Clcardref, int? Invref, int? Trcode)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_SCORING");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Clcardref.HasValue)
                query.Eq("CLCARDREF", Clcardref.Value);

            if(Invref.HasValue)
                query.Eq("INVREF", Invref.Value);

            if(Trcode.HasValue)
                query.Eq("TRCODE", Trcode.Value);

            return query.ToDataSet().ToFrList<AdmScoring>();
        }

        public DataSet GetAll()
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_SCORING");
            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
