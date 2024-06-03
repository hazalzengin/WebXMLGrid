using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmBankcreditsTypesRepo:BaseRepository<AdmBankcreditsTypes> 
    {

        public List<AdmBankcreditsTypes> GetItemClass(int? Id, String code, int? Usetype, int? Credittype, int? Interesttype, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_BANKCREDITS_TYPES");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Usetype.HasValue)
                query.Eq("USETYPE", Usetype.Value);

            if(Credittype.HasValue)
                query.Eq("CREDITTYPE", Credittype.Value);

            if(Interesttype.HasValue)
                query.Eq("INTERESTTYPE", Interesttype.Value);


            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            if (!String.IsNullOrEmpty(code))
                query.Eq("CODE", code);


            return query.ToDataSet().ToFrList<AdmBankcreditsTypes>();
        }

        public DataSet GetAll(int? Id, String code, int? Usetype, int? Credittype, int? Interesttype, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_BANKCREDITS_TYPES");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Usetype.HasValue)
                query.Eq("USETYPE", Usetype.Value);

            if(Credittype.HasValue)
                query.Eq("CREDITTYPE", Credittype.Value);

            if(Interesttype.HasValue)
                query.Eq("INTERESTTYPE", Interesttype.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            if (!String.IsNullOrEmpty(code))
                query.Eq("CODE", code);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
