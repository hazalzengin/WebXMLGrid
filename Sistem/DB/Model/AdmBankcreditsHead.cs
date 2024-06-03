using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_BANKCREDITS_HEAD için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_BANKCREDITS_HEAD")]
    public class AdmBankcreditsHead : BaseModel
    {

        #region Constructor

        public AdmBankcreditsHead()
        {

        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmBankcreditsHead_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("REFNO")]
        [ParameterType(DbType.String)]
        public string Refno { get; set; }

        [Field("KREDIADI")]
        [ParameterType(DbType.String)]
        public string Krediadi { get; set; }

        [Field("KREDITURUVALUE")]
        [ParameterType(DbType.Int32)]
        public int? Kredituruvalue { get; set; }

        [Field("KREDITURU")]
        [ParameterType(DbType.String)]
        public string Kredituru { get; set; }

        [Field("FAIZTURUVALUE")]
        [ParameterType(DbType.Int32)]
        public int? Faizturuvalue { get; set; }

        [Field("FAIZTURU")]
        [ParameterType(DbType.String)]
        public string Faizturu { get; set; }

        [Field("ALINISTARIHI")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Alinistarihi { get; set; }

        [Field("ILKTAKSITTARIHI")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Ilktaksittarihi { get; set; }

        [Field("SONTAKSITTARIHI")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Sontaksittarihi { get; set; }

        [Field("ODEMETURUVALUE")]
        [ParameterType(DbType.Int32)]
        public int? Odemeturuvalue { get; set; }

        [Field("ODEMETURU")]
        [ParameterType(DbType.String)]
        public string Odemeturu { get; set; }

        [Field("TUTARI")]
        [ParameterType(DbType.Decimal)]
        public decimal? Tutari { get; set; }

        [Field("DOVIZIVALUE")]
        [ParameterType(DbType.Int32)]
        public int? Dovizivalue { get; set; }

        [Field("DOVIZI")]
        [ParameterType(DbType.String)]
        public string Dovizi { get; set; }

        [Field("DURUMUVALUE")]
        [ParameterType(DbType.Int32)]
        public int? Durumuvalue { get; set; }

        [Field("DURUMU")]
        [ParameterType(DbType.String)]
        public string Durumu { get; set; }

        [Field("FAIZORANI")]
        [ParameterType(DbType.Decimal)]
        public decimal? Faizorani { get; set; }

        [Field("KKDFORANI")]
        [ParameterType(DbType.Decimal)]
        public decimal? Kkdforani { get; set; }

        [Field("BSMVORANI")]
        [ParameterType(DbType.Decimal)]
        public decimal? Bsmvorani { get; set; }

        [Field("KREDIBANKASIKODU")]
        [ParameterType(DbType.String)]
        public string Kredibankasikodu { get; set; }

        [Field("KREDIBANKASI")]
        [ParameterType(DbType.String)]
        public string Kredibankasi { get; set; }

        [Field("KREDIHESABIKODU")]
        [ParameterType(DbType.String)]
        public string Kredihesabikodu { get; set; }

        [Field("KREDIHESABI")]
        [ParameterType(DbType.String)]
        public string Kredihesabi { get; set; }

        [Field("TICARIHESABIKODU")]
        [ParameterType(DbType.String)]
        public string Ticarihesabikodu { get; set; }

        [Field("TICARIHESABI")]
        [ParameterType(DbType.String)]
        public string Ticarihesabi { get; set; }

        [Field("SISTEMNO")]
        [ParameterType(DbType.String)]
        public string Sistemno { get; set; }

        [Field("EXIMBANK")]
        [ParameterType(DbType.Int32)]
        public int? Eximbank { get; set; }

        [Field("KISAVADEHESABIKODU")]
        [ParameterType(DbType.String)]
        public string Kisavadehesabikodu { get; set; }

        [Field("KISAVADEHESABI")]
        [ParameterType(DbType.String)]
        public string Kisavadehesabi { get; set; }

        [Field("UZUNVADEHESABIKODU")]
        [ParameterType(DbType.String)]
        public string Uzunvadehesabikodu { get; set; }

        [Field("UZUNVADEHESABI")]
        [ParameterType(DbType.String)]
        public string Uzunvadehesabi { get; set; }

        [Field("PROJEKODU")]
        [ParameterType(DbType.String)]
        public string Projekodu { get; set; }

        [Field("PROJEKODUADI")]
        [ParameterType(DbType.String)]
        public string Projekoduadi { get; set; }

        [Field("GIDERYERIKODU")]
        [ParameterType(DbType.String)]
        public string Gideryerikodu { get; set; }

        [Field("GIDERYERI")]
        [ParameterType(DbType.String)]
        public string Gideryeri { get; set; }

        [Field("GIDERYERIORAN")]
        [ParameterType(DbType.String)]
        public string Gideryerioran { get; set; }

        [Field("GIDERYERIKODU2")]
        [ParameterType(DbType.String)]
        public string Gideryerikodu2 { get; set; }

        [Field("GIDERYERI2")]
        [ParameterType(DbType.String)]
        public string Gideryeri2 { get; set; }

        [Field("GIDERYERIORAN2")]
        [ParameterType(DbType.String)]
        public string Gideryerioran2 { get; set; }

        [Field("GIDERYERIKODU3")]
        [ParameterType(DbType.String)]
        public string Gideryerikodu3 { get; set; }

        [Field("GIDERYERI3")]
        [ParameterType(DbType.String)]
        public string Gideryeri3 { get; set; }

        [Field("GIDERYERIORAN3")]
        [ParameterType(DbType.String)]
        public string Gideryerioran3 { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        [Field("CREATEDBY")]
        [ParameterType(DbType.String)]
        public string Createdby { get; set; }

        [Field("CREATEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Createdate { get; set; }

        [Field("TAKSITSAYISI")]
        [ParameterType(DbType.Int32)]
        public int? TaksitSayýsý { get; set; }

        [Field("TAKSITPERIYODU")]
        [ParameterType(DbType.Int32)]
        public int? TaksitPeriyodu { get; set; }

        [Field("CREDITTYPE")]
        [ParameterType(DbType.Int32)]
        public int? CreditType { get; set; }


        [Field("SABITANAPARA")]
        [ParameterType(DbType.Decimal)]
        public decimal? SabitAnaPara { get; set; }


        [Field("EKLENECEKFAIZORANI")]
        [ParameterType(DbType.Decimal)]
        public decimal? EklenecekFaizOrani { get; set; }


        [Field("TLREFORANI")]
        [ParameterType(DbType.Decimal)]
        public decimal? TlrefOrani { get; set; }

        [Field("SPECODE")]
        [ParameterType(DbType.String)]
        public string Specode { get; set; }

        [Field("MASRAFTUTARI")]
        [ParameterType(DbType.Decimal)]
        public decimal? MasrafTutari { get; set; }
        #endregion

    }
}
