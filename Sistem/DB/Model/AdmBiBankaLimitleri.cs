using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_BI_BANKA_LIMITLERI için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_BI_BANKA_LIMITLERI")]
    public class AdmBiBankaLimitleri : BaseModel
    {

        #region Constructor

        public AdmBiBankaLimitleri()
        {

        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmBiBankaLimitleri_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("BANKREF")]
        [ParameterType(DbType.Int32)]
        public int? Bankref { get; set; }

        [Field("BANKCODE")]
        [ParameterType(DbType.String)]
        public string Bankcode { get; set; }

        [Field("BANKNAME")]
        [ParameterType(DbType.String)]
        public string Bankname { get; set; }

        [Field("TOPLAMLIMIT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Toplamlimit { get; set; }

        [Field("NAKDILIMIT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Nakdilimit { get; set; }

        [Field("GAYRINAKDILIMIT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Gayrinakdilimit { get; set; }

        [Field("TOPLAMLIMIT_USD")]
        [ParameterType(DbType.Decimal)]
        public decimal? ToplamlimitUSD { get; set; }

        [Field("NAKDILIMIT_USD")]
        [ParameterType(DbType.Decimal)]
        public decimal? Nakdilimit_usd { get; set; }

        [Field("GAYRINAKDILIMIT_USD")]
        [ParameterType(DbType.Decimal)]
        public decimal? Gayrinakdilimit_usd { get; set; }

        [Field("TOPLAMLIMIT_EURO")]
        [ParameterType(DbType.Decimal)]
        public decimal? ToplamlimitEURO { get; set; }

        [Field("NAKDILIMIT_EURO")]
        [ParameterType(DbType.Decimal)]
        public decimal? Nakdilimit_euro { get; set; }

        [Field("GAYRINAKDILIMIT_EURO")]
        [ParameterType(DbType.Decimal)]
        public decimal? Gayrinakdilimit_euro { get; set; }   

        [Field("KONSOLIDETOPLAMLIMIT")]
        [ParameterType(DbType.Decimal)]
        public decimal? KonsolideLimit { get; set; }

        [Field("BANKTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Banktype { get; set; }

        [Field("FIRMNR")]
        [ParameterType(DbType.Int32)]
        public int? Firmnr { get; set; }

        [Field("CURRENCY")]
        [ParameterType(DbType.Int32)]
        public int? Currency { get; set; }

        [Field("UPDATEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Updatedate { get; set; }

        [Field("UPDATEDBY")]
        [ParameterType(DbType.String)]
        public string Updatedby { get; set; }

        [Field("CREATEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Createdate { get; set; }

        [Field("CREATEDBY")]
        [ParameterType(DbType.String)]
        public string Createdby { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        [Field("CEKLIMITI")]
        [ParameterType(DbType.Decimal)]
        public decimal? CekLimiti { get; set; }

        [Field("KREDIKARTILIMITI")]
        [ParameterType(DbType.Decimal)]
        public decimal? KrediKartiLimiti { get; set; }

        [Field("TEMINATMEKTUBULIMITI")]
        [ParameterType(DbType.Decimal)]
        public decimal? TeminatMektubuLimiti { get; set; }

        [Field("DBSLIMITI")]
        [ParameterType(DbType.Decimal)]
        public decimal? DbsLimiti { get; set; }

        [Field("AKREDITIFLIMITI")]
        [ParameterType(DbType.Decimal)]
        public decimal? AkreditifLimiti { get; set; }
        #endregion

    }
}
