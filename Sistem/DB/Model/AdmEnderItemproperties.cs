using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_ENDER_ITEMPROPERTIES için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_ENDER_ITEMPROPERTIES")]
    public class AdmEnderItemproperties : BaseModel
    {

        #region Constructor

        public AdmEnderItemproperties()
        {

        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmEnderItemproperties_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("ANA_KOD")]
        [ParameterType(DbType.String)]
        public string AnaKod { get; set; }

        [Field("ESKI_KOD")]
        [ParameterType(DbType.String)]
        public string EskiKod { get; set; }

        [Field("MARKA")]
        [ParameterType(DbType.String)]
        public string Marka { get; set; }

        [Field("SERINO")]
        [ParameterType(DbType.String)]
        public string Serino { get; set; }

        [Field("URUN_ADI")]
        [ParameterType(DbType.String)]
        public string UrunAdi { get; set; }

        [Field("KAPLAMA")]
        [ParameterType(DbType.String)]
        public string Kaplama { get; set; }

        [Field("LAMINE_RENK")]
        [ParameterType(DbType.String)]
        public string LamineRenk { get; set; }

        [Field("HAMUR_RENK")]
        [ParameterType(DbType.String)]
        public string HamurRenk { get; set; }

        [Field("CONTA_RENK")]
        [ParameterType(DbType.String)]
        public string ContaRenk { get; set; }

        [Field("OZELKOD_ADI")]
        [ParameterType(DbType.String)]
        public string OzelkodAdi { get; set; }

        [Field("PAKET_MIKTAR")]
        [ParameterType(DbType.Double)]
        public double? PaketMiktar { get; set; }

        [Field("BOY")]
        [ParameterType(DbType.Double)]
        public double? Boy { get; set; }

        [Field("ISKONTO_LAMINE_ADI")]
        [ParameterType(DbType.String)]
        public string IskontoLamineAdi { get; set; }

        [Field("FIYAT_GRUBU")]
        [ParameterType(DbType.String)]
        public string FiyatGrubu { get; set; }

        [Field("ERP_KODU")]
        [ParameterType(DbType.String)]
        public string ErpKodu { get; set; }

        [Field("KORUMA_BANT")]
        [ParameterType(DbType.String)]
        public string KorumaBant { get; set; }

        [Field("SERI_KODU")]
        [ParameterType(DbType.String)]
        public string SeriKodu { get; set; }

        [Field("URUNADI_KODU")]
        [ParameterType(DbType.String)]
        public string UrunadiKodu { get; set; }

        [Field("KAPLAMA_KODU")]
        [ParameterType(DbType.String)]
        public string KaplamaKodu { get; set; }

        [Field("LAMINERENK_KODU")]
        [ParameterType(DbType.String)]
        public string LaminerenkKodu { get; set; }

        [Field("HAMURRENK_KODU")]
        [ParameterType(DbType.String)]
        public string HamurrenkKodu { get; set; }

        [Field("CONTARENK_KODU")]
        [ParameterType(DbType.String)]
        public string ContarenkKodu { get; set; }

        [Field("OZELKOD")]
        [ParameterType(DbType.String)]
        public string Ozelkod { get; set; }

        [Field("ISKONTO_LAMINE_KODU")]
        [ParameterType(DbType.String)]
        public string IskontoLamineKodu { get; set; }

        [Field("FIYAT_GRUBU1")]
        [ParameterType(DbType.String)]
        public string FiyatGrubu1 { get; set; }

        [Field("URUN_KODU")]
        [ParameterType(DbType.String)]
        public string UrunKodu { get; set; }

        [Field("RENK_KODU")]
        [ParameterType(DbType.String)]
        public string RenkKodu { get; set; }

        [Field("TIP_KODU")]
        [ParameterType(DbType.String)]
        public string TipKodu { get; set; }

        [Field("URUN_ACIKLAMASI")]
        [ParameterType(DbType.String)]
        public string UrunAciklamasi { get; set; }

        [Field("TIP_ACIKLAMASI")]
        [ParameterType(DbType.String)]
        public string TipAciklamasi { get; set; }

        [Field("RENK")]
        [ParameterType(DbType.String)]
        public string Renk { get; set; }

        [Field("CONTA")]
        [ParameterType(DbType.String)]
        public string Conta { get; set; }

        [Field("METRE_KG")]
        [ParameterType(DbType.Double)]
        public double? MetreKg { get; set; }

        [Field("CONTALI_GRAMAJ")]
        [ParameterType(DbType.Double)]
        public double? ContaliGramaj { get; set; }

        [Field("CONTA_KG")]
        [ParameterType(DbType.Double)]
        public double? ContaKg { get; set; }

        [Field("DIGER1")]
        [ParameterType(DbType.String)]
        public string Diger1 { get; set; }

        [Field("DIGER2")]
        [ParameterType(DbType.String)]
        public string Diger2 { get; set; }

        [Field("CREATEDBY")]
        [ParameterType(DbType.String)]
        public string Createdby { get; set; }

        [Field("CREATEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Createdate { get; set; }

        [Field("UPDATEDBY")]
        [ParameterType(DbType.String)]
        public string Updatedby { get; set; }

        [Field("UPDATEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Updatedate { get; set; }

        [Field("DELETEDBY")]
        [ParameterType(DbType.String)]
        public string Deletedby { get; set; }

        [Field("DELETEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Deletedate { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
