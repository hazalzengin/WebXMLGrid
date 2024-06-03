using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmEnderOfferRepo:BaseRepository<AdmEnderOffer> 
    {

        public List<AdmEnderOffer> GetItemClass(int? Id, int? Status, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ENDER_OFFER");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Status.HasValue)
                query.Eq("STATUS", Status.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmEnderOffer>();
        }

        public DataSet GetAll(int? Id, int? Status, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ENDER_OFFER");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Status.HasValue)
                query.Eq("STATUS", Status.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
