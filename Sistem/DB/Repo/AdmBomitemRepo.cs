using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmBomitemRepo:BaseRepository<AdmBomitem> 
    {

        public List<AdmBomitem> GetItemClass(int? Id, string bomcode, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_BOMITEM");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if (!string.IsNullOrWhiteSpace(bomcode))
            {
                query.Eq("BOMCODE", bomcode);
            }

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmBomitem>();
        }

        public DataSet GetAll(string LANGU, int? Id, string bomcode, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_BOMITEM");

            if (!string.IsNullOrWhiteSpace(LANGU))
            {
                query.Eq("LANGU", LANGU);
            }
            if (!string.IsNullOrWhiteSpace(bomcode))
            {
                query.Eq("BOMCODE", bomcode);
            }

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Asc).ToDataSet();
        }


    }
}
