using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmTmzOfferRepo:BaseRepository<AdmTmzOffer> 
    {

        public List<AdmTmzOffer> GetItemClass(int? Id, int? LgClcardref, int? Status, int? Isdel, int? TransferStatus)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_TMZ_OFFER");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(LgClcardref.HasValue)
                query.Eq("LG_CLCARDREF", LgClcardref.Value);

            if(Status.HasValue)
                query.Eq("STATUS", Status.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            if(TransferStatus.HasValue)
                query.Eq("TRANSFER_STATUS", TransferStatus.Value);

            return query.ToDataSet().ToFrList<AdmTmzOffer>();
        }

        public DataSet GetAll(int? Id, int? LgClcardref, int? Status, int? Isdel, int? TransferStatus)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_TMZ_OFFER");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(LgClcardref.HasValue)
                query.Eq("LG_CLCARDREF", LgClcardref.Value);

            if(Status.HasValue)
                query.Eq("STATUS", Status.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            if(TransferStatus.HasValue)
                query.Eq("TRANSFER_STATUS", TransferStatus.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
