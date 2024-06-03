using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmEdcOfferApprovalRepo:BaseRepository<AdmEdcOfferApproval> 
    {

        public List<AdmEdcOfferApproval> GetItemClass(int? Id, int? Offerref)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_EDC_OFFER_APPROVAL");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Offerref.HasValue)
                query.Eq("OFFERREF", Offerref.Value);

            return query.ToDataSet().ToFrList<AdmEdcOfferApproval>();
        }

        public DataSet GetAll(int? Id, int? Offerref)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_EDC_OFFER_APPROVAL");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Offerref.HasValue)
                query.Eq("OFFERREF", Offerref.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
