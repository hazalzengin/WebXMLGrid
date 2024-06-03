using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmRouoprRepo:BaseRepository<AdmRouopr> 
    {

        public List<AdmRouopr> GetItemClass(int? Id, string Itemcode, string Roucode, string Code, string Oprnum, int? Workcenter, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ROUOPR");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if(!string.IsNullOrWhiteSpace(Roucode))
                query.Eq("ROUCODE", Roucode);

            if(!string.IsNullOrWhiteSpace(Code))
                query.Eq("CODE", Code);

            if(!string.IsNullOrWhiteSpace(Oprnum))
                query.Eq("OPRNUM", Oprnum);

            if(Workcenter.HasValue)
                query.Eq("WORKCENTER", Workcenter.Value);

            if(Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("OPRNUM",OrderDirection.Asc).ToDataSet().ToFrList<AdmRouopr>();
        }

        public DataSet GetAll(string LANGU, int? Id, string Itemcode, string Roucode, string Code, string Oprnum, int? Workcenter, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_ROUOPR");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (!string.IsNullOrWhiteSpace(LANGU))
            {
                query.Eq("LANGU", LANGU);
            }

            if (!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if (!string.IsNullOrWhiteSpace(Roucode))
                query.Eq("ROUCODE", Roucode);

            if (!string.IsNullOrWhiteSpace(Code))
                query.Eq("CODE", Code);

            if (!string.IsNullOrWhiteSpace(Oprnum))
                query.Eq("OPRNUM", Oprnum);

            if (Workcenter.HasValue)
                query.Eq("WORKCENTER", Workcenter.Value);

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);


            return query.OrderBy("OPRNUM", OrderDirection.Asc).ToDataSet();
        }


    }
}
