using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmBankcreditsHeadRepo:BaseRepository<AdmBankcreditsHead> 
    {

        public List<AdmBankcreditsHead> GetItemClass(int? Id, int? Refno, int? Kredituruvalue, int? Faizturuvalue, int? Odemeturuvalue, int? Dovizivalue, int? Durumuvalue, int? Eximbank, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_BANKCREDITS_HEAD");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Refno.HasValue)
                query.Eq("REFNO", Refno.Value);

            if(Kredituruvalue.HasValue)
                query.Eq("KREDITURUVALUE", Kredituruvalue.Value);

            if(Faizturuvalue.HasValue)
                query.Eq("FAIZTURUVALUE", Faizturuvalue.Value);

            if(Odemeturuvalue.HasValue)
                query.Eq("ODEMETURUVALUE", Odemeturuvalue.Value);

            if(Dovizivalue.HasValue)
                query.Eq("DOVIZIVALUE", Dovizivalue.Value);

            if(Durumuvalue.HasValue)
                query.Eq("DURUMUVALUE", Durumuvalue.Value);

            if(Eximbank.HasValue)
                query.Eq("EXIMBANK", Eximbank.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmBankcreditsHead>();
        }

        public DataSet GetAll(int? Id, int? Refno, int? Kredituruvalue, int? Faizturuvalue, int? Odemeturuvalue, int? Dovizivalue, int? Durumuvalue, int? Eximbank, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_BANKCREDITS_HEAD");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Refno.HasValue)
                query.Eq("REFNO", Refno.Value);

            if(Kredituruvalue.HasValue)
                query.Eq("KREDITURUVALUE", Kredituruvalue.Value);

            if(Faizturuvalue.HasValue)
                query.Eq("FAIZTURUVALUE", Faizturuvalue.Value);

            if(Odemeturuvalue.HasValue)
                query.Eq("ODEMETURUVALUE", Odemeturuvalue.Value);

            if(Dovizivalue.HasValue)
                query.Eq("DOVIZIVALUE", Dovizivalue.Value);

            if(Durumuvalue.HasValue)
                query.Eq("DURUMUVALUE", Durumuvalue.Value);

            if(Eximbank.HasValue)
                query.Eq("EXIMBANK", Eximbank.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }

        public List<AdmBankcreditsHead> GetItemClass(int? Id, int? Refno, int? Kredituruvalue, int? Faizturuvalue, int? Odemeturuvalue, int? Dovizivalue, int? Durumuvalue, int? Eximbank, int? Isdel
            , DateTime? dtBas,DateTime? dtBit,int? creditType)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_BANKCREDITS_HEAD");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Refno.HasValue)
                query.Eq("REFNO", Refno.Value);

            if (Kredituruvalue.HasValue)
                query.Eq("KREDITURUVALUE", Kredituruvalue.Value);

            if (Faizturuvalue.HasValue)
                query.Eq("FAIZTURUVALUE", Faizturuvalue.Value);

            if (Odemeturuvalue.HasValue)
                query.Eq("ODEMETURUVALUE", Odemeturuvalue.Value);

            if (Dovizivalue.HasValue)
                query.Eq("DOVIZIVALUE", Dovizivalue.Value);

            if (Durumuvalue.HasValue)
                query.Eq("DURUMUVALUE", Durumuvalue.Value);

            if (Eximbank.HasValue)
                query.Eq("EXIMBANK", Eximbank.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            if (dtBas.HasValue)
                query.GreaterOrEqual("ILKTAKSITTARIHI", dtBas.Value);

            if (dtBit.HasValue)
                query.LessOrEqual("SONTAKSITTARIHI", dtBit.Value);

            if (creditType.HasValue)
                query.Eq("CREDITTYPE", creditType.Value);

            return query.ToDataSet().ToFrList<AdmBankcreditsHead>();
        }


    }
}
