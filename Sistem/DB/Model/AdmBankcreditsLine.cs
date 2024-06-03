using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_BANKCREDITS_LINE için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_BANKCREDITS_LINE")]
    public class AdmBankcreditsLine : BaseModel
    {

        #region Constructor

        public AdmBankcreditsLine()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmBankcreditsLine_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("HEADREF")]
        [ParameterType(DbType.Int32)]
        public int? Headref { get; set; }

        [Field("ISLEMTURUVALUE")]
        [ParameterType(DbType.Int32)]
        public int? Islemturuvalue { get; set; }

        [Field("ISLEMTURU")]
        [ParameterType(DbType.String)]
        public string Islemturu { get; set; }

        [Field("TAKSITNO")]
        [ParameterType(DbType.Int32)]
        public int? Taksitno { get; set; }

        [Field("TARIH")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Tarih { get; set; }

        [Field("FAIZORANI")]
        [ParameterType(DbType.Decimal)]
        public decimal? Faizorani { get; set; }

        [Field("KALANANAPARA")]
        [ParameterType(DbType.Decimal)]
        public decimal? Kalananapara { get; set; }

        [Field("ANAPARA")]
        [ParameterType(DbType.Decimal)]
        public decimal? Anapara { get; set; }

        [Field("FAIZ")]
        [ParameterType(DbType.Decimal)]
        public decimal? Faiz { get; set; }

        [Field("KKDF")]
        [ParameterType(DbType.Decimal)]
        public decimal? Kkdf { get; set; }

        [Field("BSMV")]
        [ParameterType(DbType.Decimal)]
        public decimal? Bsmv { get; set; }

        [Field("FAIZTOPLAM")]
        [ParameterType(DbType.Decimal)]
        public decimal? FaizToplam { get; set; }

        [Field("ODEME")]
        [ParameterType(DbType.Decimal)]
        public decimal? Odeme { get; set; }

        [Field("KALAN")]
        [ParameterType(DbType.Decimal)]
        public decimal? Kalan { get; set; }

        [Field("DURUMUVALUE")]
        [ParameterType(DbType.Int32)]
        public int? Durumuvalue { get; set; }

        [Field("DURUMU")]
        [ParameterType(DbType.String)]
        public string Durumu { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        [Field("CREATEDBY")]
        [ParameterType(DbType.String)]
        public string Createdby { get; set; }

        [Field("CREATEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Createdate { get; set; }

        [Field("ISTRANSFERRED")]
        [ParameterType(DbType.Int32)]
        public int? IsTransferred { get; set; }

        [Field("TRANSFERREF")]
        [ParameterType(DbType.Int32)]
        public int? TransferRef { get; set; }

        [Field("TRANSFERDOCODE")]
        [ParameterType(DbType.String)]
        public string TransferDocode { get; set; }

        [Field("GECENGUN")]
        [ParameterType(DbType.Int32)]
        public int? GecenGun { get; set; }

        [Field("GUNLUKFAIZ")]
        [ParameterType(DbType.Decimal)]
        public decimal? GunlukFaiz { get; set; }

        [Field("GUIDID")]
        [ParameterType(DbType.String)]
        public string GuidId { get; set; }

        #endregion

    }
}
