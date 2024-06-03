using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_ENDER_EKMALIYET için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_ENDER_EKMALIYET")]
    public class AdmEnderEkmaliyet : BaseModel
    {

        #region Constructor

        public AdmEnderEkmaliyet()
        {

        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmEnderEkmaliyet_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("BASLANGIC_TARIHI")]
        [ParameterType(DbType.DateTime)]
        public DateTime? BaslangicTarihi { get; set; }

        [Field("BITIS_TARIHI")]
        [ParameterType(DbType.DateTime)]
        public DateTime? BitisTarihi { get; set; }

        [Field("HAMURKODU")]
        [ParameterType(DbType.String)]
        public string Hamurkodu { get; set; }

        [Field("HAMURTURU")]
        [ParameterType(DbType.String)]
        public string Hamurturu { get; set; }

        [Field("MALIYETKODU")]
        [ParameterType(DbType.String)]
        public string Maliyetkodu { get; set; }

        [Field("MALIYETADI")]
        [ParameterType(DbType.String)]
        public string Maliyetadi { get; set; }

        [Field("URETIM_MIKTAR_KG")]
        [ParameterType(DbType.Double)]
        public double? UretimMiktarKg { get; set; }

        [Field("URETIM_MIKTAR_KG_LAMINE")]
        [ParameterType(DbType.Double)]
        public double? UretimMiktarKgLamine { get; set; }

        [Field("URETIM_MIKTAR_M2")]
        [ParameterType(DbType.Double)]
        public double? UretimMiktarM2 { get; set; }

        [Field("URETIM_MIKTAR_M2_LAMINE")]
        [ParameterType(DbType.Double)]
        public double? UretimMiktarM2Lamine { get; set; }

        [Field("IS_LAMINE")]
        [ParameterType(DbType.Int32)]
        public int? IsLamine { get; set; }

        [Field("TUTAR_TRY")]
        [ParameterType(DbType.Double)]
        public double? TutarTry { get; set; }

        [Field("TUTAR_USD")]
        [ParameterType(DbType.Double)]
        public double? TutarUsd { get; set; }

        [Field("TUTAR_EUR")]
        [ParameterType(DbType.Double)]
        public double? TutarEur { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
