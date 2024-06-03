using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmBankcreditsLineRepo:BaseRepository<AdmBankcreditsLine> 
    {

        public List<AdmBankcreditsLine> GetItemClass(int? Id, int? Headref, int? Islemturuvalue, int? Taksitno, int? Durumuvalue, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_BANKCREDITS_LINE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Headref.HasValue)
                query.Eq("HEADREF", Headref.Value);

            if(Islemturuvalue.HasValue)
                query.Eq("ISLEMTURUVALUE", Islemturuvalue.Value);

            if(Taksitno.HasValue)
                query.Eq("TAKSITNO", Taksitno.Value);

            if(Durumuvalue.HasValue)
                query.Eq("DURUMUVALUE", Durumuvalue.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmBankcreditsLine>();
        }

        public DataSet GetAll(int? Id, int? Headref, int? Islemturuvalue, int? Taksitno, int? Durumuvalue, int? Isdel,int? IsTransferred)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_BANKCREDITS_LINE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Headref.HasValue)
                query.Eq("HEADREF", Headref.Value);

            if(Islemturuvalue.HasValue)
                query.Eq("ISLEMTURUVALUE", Islemturuvalue.Value);

            if(Taksitno.HasValue)
                query.Eq("TAKSITNO", Taksitno.Value);

            if(Durumuvalue.HasValue)
                query.Eq("DURUMUVALUE", Durumuvalue.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            if (IsTransferred.HasValue)
                query.Eq("ISTRANSFERRED", IsTransferred.Value);

            return query.OrderBy("ID", OrderDirection.Asc).ToDataSet();
        }


    }
}
