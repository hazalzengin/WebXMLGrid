using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_ENDER_ALISBIRIMMALIYET için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_ENDER_ALISBIRIMMALIYET")]
    public class AdmEnderAlisbirimmaliyet : BaseModel
    {

        #region Constructor

        public AdmEnderAlisbirimmaliyet()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmEnderAlisbirimmaliyet_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("TERMIN_YERI")]
        [ParameterType(DbType.String)]
        public string TerminYeri { get; set; }

        [Field("ITEMREF")]
        [ParameterType(DbType.Int32)]
        public int? Itemref { get; set; }

        [Field("STOK_KODU")]
        [ParameterType(DbType.String)]
        public string StokKodu { get; set; }

        [Field("STOK_ACIKLAMASI")]
        [ParameterType(DbType.String)]
        public string StokAciklamasi { get; set; }

        [Field("BIRIM")]
        [ParameterType(DbType.String)]
        public string Birim { get; set; }

        [Field("BIRIM_MIKTAR")]
        [ParameterType(DbType.Double)]
        public double? BirimMiktar { get; set; }

        [Field("TUTAR_TRY")]
        [ParameterType(DbType.Double)]
        public double? TutarTry { get; set; }

        [Field("TUTAR_USD")]
        [ParameterType(DbType.Double)]
        public double? TutarUsd { get; set; }

        [Field("TUTAR_EUR")]
        [ParameterType(DbType.Double)]
        public double? TutarEur { get; set; }

        [Field("GUMRUK_USD")]
        [ParameterType(DbType.Double)]
        public double? GumrukUsd { get; set; }

        #endregion

    }
}
