using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmSalorderheadRepo:BaseRepository<AdmSalorderhead> 
    {

        public List<AdmSalorderhead> GetItemClass(int? Id, int? Iscompleted, int? Paymenttype)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_SALORDERHEAD");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Iscompleted.HasValue)
                query.Eq("ISCOMPLETED", Iscompleted.Value);

            if(Paymenttype.HasValue)
                query.Eq("PAYMENTTYPE", Paymenttype.Value);

            return query.ToDataSet().ToFrList<AdmSalorderhead>();
        }

        public DataSet GetAll(int? Id, int? Iscompleted, int? Paymenttype)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_SALORDERHEAD");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Iscompleted.HasValue)
                query.Eq("ISCOMPLETED", Iscompleted.Value);

            if(Paymenttype.HasValue)
                query.Eq("PAYMENTTYPE", Paymenttype.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
