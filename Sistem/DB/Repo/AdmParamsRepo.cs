using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmParamsRepo : BaseRepository<AdmParams>
    {

        public List<AdmParams> GetItemClass(int id, string PTYPE, string PCODE, int isDel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PARAMS");

            if (id > -1)
            {
                query.Eq("ID", id);
            }

            if (!string.IsNullOrWhiteSpace(PTYPE))
            {
                query.Eq("PTYPE", PTYPE);
            }

            if (!string.IsNullOrWhiteSpace(PCODE))
            {
                query.Eq("PCODE", PCODE);
            }

            if (isDel > -1)
            {
                query.Eq("ISDEL", isDel);
            }
            return query.ToDataSet().ToFrList<AdmParams>();
        }

        public DataSet GetAll(int id, string LANGU, string PTYPE, string PCODE, int isActive, int isDel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_PARAMS");

            if (id > -1)
            {
                query.Eq("ID", id);
            }

            if (!string.IsNullOrWhiteSpace(PTYPE))
            {
                query.Eq("PTYPE", PTYPE);
            }

            if (!string.IsNullOrWhiteSpace(PCODE))
            {
                query.Eq("PCODE", PCODE);
            }

            if (!string.IsNullOrWhiteSpace(LANGU))
            {
                query.Eq("LANGU", LANGU);
            }
            if (isActive > -1)
            {
                query.Eq("ISACTIVE", isActive);
            }
            if (isDel > -1)
            {
                query.Eq("ISDEL", isDel);
            }
            return query.OrderBy("ID", OrderDirection.Asc).ToDataSet();
        }


    }
}
