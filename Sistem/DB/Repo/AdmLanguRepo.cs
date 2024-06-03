using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmLanguRepo : BaseRepository<AdmLangu>
    {

        public List<AdmLangu> GetItemClass(int id, string TABLEN, string REFID, string LANGU)
        {
            var query = new FrQueryBase(dbo);
            query.From(TABLEN);

            if (id > -1)
            {
                query.Eq("ID", id);
            }

            //if (!string.IsNullOrWhiteSpace(TABLEN))
            //    query.Eq("TABLEN", TABLEN);

            if (!string.IsNullOrWhiteSpace(REFID))
                query.Eq("REFID", REFID);

            if (!string.IsNullOrWhiteSpace(LANGU))
                query.Eq("LANGU", LANGU);

            return query.ToDataSet().ToFrList<AdmLangu>();
        }

        public DataSet GetAll(string TABLEN, string REFID, string LANGU)
        {
            var query = new FrQueryBase(dbo);
            query.From(TABLEN);

            //if (!string.IsNullOrWhiteSpace(TABLEN))
            //    query.Eq("TABLEN", TABLEN);

            if (!string.IsNullOrWhiteSpace(REFID))
                query.Eq("REFID", REFID);

            if (!string.IsNullOrWhiteSpace(LANGU))
                query.Eq("LANGU", LANGU);
            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
