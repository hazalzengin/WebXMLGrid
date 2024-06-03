using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmBiReferansfaizRepo:BaseRepository<AdmBiReferansfaiz> 
    {

        public List<AdmBiReferansfaiz> GetItemClass(int? Id, int? Faiztype, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_BI_REFERANSFAIZ");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Faiztype.HasValue)
                query.Eq("FAIZTYPE", Faiztype.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmBiReferansfaiz>();
        }

        public DataSet GetAll(int? Id, int? Faiztype, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_BI_REFERANSFAIZ");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Faiztype.HasValue)
                query.Eq("FAIZTYPE", Faiztype.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
