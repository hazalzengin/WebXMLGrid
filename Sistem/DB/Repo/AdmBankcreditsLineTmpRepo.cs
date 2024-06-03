using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmBankcreditsLineTmpRepo:BaseRepository<AdmBankcreditsLineTmp> 
    {

        public List<AdmBankcreditsLineTmp> GetItemClass(int? Id, int? Headref, int? Islemturuvalue, int? Taksitno, int? Gecengun, int? Durumuvalue, int? Isdel, int? Istransferred, int? Transferref)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_BANKCREDITS_LINE_tmp");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Headref.HasValue)
                query.Eq("HEADREF", Headref.Value);

            if(Islemturuvalue.HasValue)
                query.Eq("ISLEMTURUVALUE", Islemturuvalue.Value);

            if(Taksitno.HasValue)
                query.Eq("TAKSITNO", Taksitno.Value);

            if(Gecengun.HasValue)
                query.Eq("GECENGUN", Gecengun.Value);

            if(Durumuvalue.HasValue)
                query.Eq("DURUMUVALUE", Durumuvalue.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            if(Istransferred.HasValue)
                query.Eq("ISTRANSFERRED", Istransferred.Value);

            if(Transferref.HasValue)
                query.Eq("TRANSFERREF", Transferref.Value);

            return query.ToDataSet().ToFrList<AdmBankcreditsLineTmp>();
        }

        public DataSet GetAll(int? Id, int? Headref, int? Islemturuvalue, int? Taksitno, int? Gecengun, int? Durumuvalue, int? Isdel, int? Istransferred, int? Transferref)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_BANKCREDITS_LINE_tmp");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Headref.HasValue)
                query.Eq("HEADREF", Headref.Value);

            if(Islemturuvalue.HasValue)
                query.Eq("ISLEMTURUVALUE", Islemturuvalue.Value);

            if(Taksitno.HasValue)
                query.Eq("TAKSITNO", Taksitno.Value);

            if(Gecengun.HasValue)
                query.Eq("GECENGUN", Gecengun.Value);

            if(Durumuvalue.HasValue)
                query.Eq("DURUMUVALUE", Durumuvalue.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            if(Istransferred.HasValue)
                query.Eq("ISTRANSFERRED", Istransferred.Value);

            if(Transferref.HasValue)
                query.Eq("TRANSFERREF", Transferref.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
