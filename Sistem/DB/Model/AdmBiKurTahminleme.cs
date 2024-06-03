using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_BI_KUR_TAHMINLEME için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_BI_KUR_TAHMINLEME")]
    public class AdmBiKurTahminleme : BaseModel
    {

        #region Constructor

        public AdmBiKurTahminleme()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmBiKurTahminleme_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Date_ { get; set; }

        [Field("AY")]
        [ParameterType(DbType.String)]
        public string Ay { get; set; }

        [Field("YIL")]
        [ParameterType(DbType.String)]
        public string Yil { get; set; }

        [Field("CURRENCYTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Currencytype { get; set; }

        [Field("CURRENCYNAME")]
        [ParameterType(DbType.String)]
        public string Currencyname { get; set; }

        [Field("CURRENCY")]
        [ParameterType(DbType.Decimal)]
        public decimal? Currency { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
