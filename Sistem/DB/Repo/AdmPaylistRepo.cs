using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmPaylistRepo : BaseRepository<AdmPaylist>
    {

        public List<AdmPaylist> GetItemClass(int? Id, int? Sourcetype, int? Currency, int? Status)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PAYLIST");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Sourcetype.HasValue)
                query.Eq("SOURCETYPE", Sourcetype.Value);

            if (Currency.HasValue)
                query.Eq("CURRENCY", Currency.Value);

            if (Status.HasValue)
                query.Eq("STATUS", Status.Value);

            return query.ToDataSet().ToFrList<AdmPaylist>();
        }

        public DataSet GetAll(int? Id, int? Sourcetype, int? Currency, int? Status)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PAYLIST");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Sourcetype.HasValue)
                query.Eq("SOURCETYPE", Sourcetype.Value);

            if (Currency.HasValue)
                query.Eq("CURRENCY", Currency.Value);

            if (Status.HasValue)
                query.Eq("STATUS", Status.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
