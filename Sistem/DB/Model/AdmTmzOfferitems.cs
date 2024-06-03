using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_TMZ_OFFERITEMS için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_TMZ_OFFERITEMS")]
    public class AdmTmzOfferitems : BaseModel
    {

        #region Constructor

        public AdmTmzOfferitems()
        {

        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmTmzOfferitems_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("PARENTREF")]
        [ParameterType(DbType.Int32)]
        public int? Parentref { get; set; }

        [Field("ISGROUPORBASE")]
        [ParameterType(DbType.Int32)]
        public int? Isgrouporbase { get; set; }

        [Field("ITEMGROUPCODE")]
        [ParameterType(DbType.String)]
        public string Itemgroupcode { get; set; }

        [Field("ITEMGROUPREF")]
        [ParameterType(DbType.Int32)]
        public int? Itemgroupref { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Date_ { get; set; }

        [Field("DUEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Duedate { get; set; }

        [Field("SHIPDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Shipdate { get; set; }

        [Field("ISATLASITEM")]
        [ParameterType(DbType.Int32)]
        public int? Isatlasitem { get; set; }

        [Field("ITEMREF")]
        [ParameterType(DbType.Int32)]
        public int? Itemref { get; set; }

        [Field("ITEMCODE")]
        [ParameterType(DbType.String)]
        public string Itemcode { get; set; }

        [Field("ITEMNAME")]
        [ParameterType(DbType.String)]
        public string Itemname { get; set; }

        [Field("AMOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Amount { get; set; }

        [Field("PRODAMOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Prodamount { get; set; }

        [Field("UNIT")]
        [ParameterType(DbType.String)]
        public string Unit { get; set; }

        [Field("UNITPRICE")]
        [ParameterType(DbType.Decimal)]
        public decimal? Unitprice { get; set; }

        [Field("UNITPRICECUR")]
        [ParameterType(DbType.Decimal)]
        public decimal? Unitpricecur { get; set; }

        [Field("CURRENCYTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Currencytype { get; set; }

        [Field("CURRENCYRATE")]
        [ParameterType(DbType.Decimal)]
        public decimal? Currencyrate { get; set; }

        [Field("VATRATE")]
        [ParameterType(DbType.Decimal)]
        public decimal? Vatrate { get; set; }

        [Field("VATTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Vattype { get; set; }

        [Field("DISCOUNT1")]
        [ParameterType(DbType.Decimal)]
        public decimal? Discount1 { get; set; }

        [Field("DISCOUNT2")]
        [ParameterType(DbType.Decimal)]
        public decimal? Discount2 { get; set; }

        [Field("DISCOUNT3")]
        [ParameterType(DbType.Decimal)]
        public decimal? Discount3 { get; set; }

        [Field("EXP_IMPORTANT")]
        [ParameterType(DbType.String)]
        public string ExpImportant { get; set; }

        [Field("EXP1")]
        [ParameterType(DbType.String)]
        public string Exp1 { get; set; }

        [Field("BANT")]
        [ParameterType(DbType.String)]
        public string Bant { get; set; }

        [Field("ISKALIPVAR")]
        [ParameterType(DbType.Int32)]
        public int? Iskalipvar { get; set; }

        [Field("ISTASIRMAVAR")]
        [ParameterType(DbType.Int32)]
        public int? Istasirmavar { get; set; }

        [Field("URUN_TIPI")]
        [ParameterType(DbType.String)]
        public string UrunTipi { get; set; }

        [Field("IC_KAGIDIREF")]
        [ParameterType(DbType.Int32)]
        public int? IcKagidiref { get; set; }

        [Field("IC_KAGIDICODE")]
        [ParameterType(DbType.String)]
        public string IcKagidicode { get; set; }

        [Field("IC_KAGIDINAME")]
        [ParameterType(DbType.String)]
        public string IcKagidiname { get; set; }

        [Field("IC_MAKINEREF")]
        [ParameterType(DbType.Int32)]
        public int? IcMakineref { get; set; }

        [Field("IC_TABAKA_EBAT")]
        [ParameterType(DbType.String)]
        public string IcTabakaEbat { get; set; }

        [Field("IC_TABAKADA_ADET")]
        [ParameterType(DbType.Int32)]
        public int? IcTabakadaAdet { get; set; }

        [Field("TUTKALREF")]
        [ParameterType(DbType.Int32)]
        public int? Tutkalref { get; set; }

        [Field("TUTKALCODE")]
        [ParameterType(DbType.String)]
        public string Tutkalcode { get; set; }

        [Field("TUTKALNAME")]
        [ParameterType(DbType.String)]
        public string Tutkalname { get; set; }

        [Field("TUTKAL_CINSIREF")]
        [ParameterType(DbType.Int32)]
        public int? TutkalCinsiref { get; set; }

        [Field("TUTKAL_KODU")]
        [ParameterType(DbType.String)]
        public string TutkalKodu { get; set; }

        [Field("KAGIT_MARKA_ETIKET")]
        [ParameterType(DbType.String)]
        public string KagitMarkaEtiket { get; set; }

        [Field("SARIM_ADET")]
        [ParameterType(DbType.Int32)]
        public int? SarimAdet { get; set; }

        [Field("RULO_CAPI")]
        [ParameterType(DbType.String)]
        public string RuloCapi { get; set; }

        [Field("KAPAK_KAGIDIREF")]
        [ParameterType(DbType.Int32)]
        public int? KapakKagidiref { get; set; }

        [Field("KAPAK_KAGIDICODE")]
        [ParameterType(DbType.String)]
        public string KapakKagidicode { get; set; }

        [Field("KAPAK_KAGIDINAME")]
        [ParameterType(DbType.String)]
        public string KapakKagidiname { get; set; }

        [Field("KAPAK_MAKINEREF")]
        [ParameterType(DbType.Int32)]
        public int? KapakMakineref { get; set; }

        [Field("KAPAK_TABAKA_EBAT")]
        [ParameterType(DbType.String)]
        public string KapakTabakaEbat { get; set; }

        [Field("KAPAK_TABAKADA_ADET")]
        [ParameterType(DbType.Int32)]
        public int? KapakTabakadaAdet { get; set; }

        [Field("BUYUK_TABAKA_EBAT")]
        [ParameterType(DbType.String)]
        public string BuyukTabakaEbat { get; set; }

        [Field("BUYUK_TABAKADA_ADET")]
        [ParameterType(DbType.Int32)]
        public int? BuyukTabakadaAdet { get; set; }

        [Field("KAPAK_BUYUK_TABAKA_EBAT")]
        [ParameterType(DbType.String)]
        public string KapakBuyukTabakaEbat { get; set; }

        [Field("KAPAK_BUYUK_TABAKADA_ADET")]
        [ParameterType(DbType.Int32)]
        public int? KapakBuyukTabakadaAdet { get; set; }

        [Field("ARTIK_MAKINEREF")]
        [ParameterType(DbType.Int32)]
        public int? ArtikMakineref { get; set; }

        [Field("ARTIK_TABAKADA_ADET")]
        [ParameterType(DbType.Int32)]
        public int? ArtikTabakadaAdet { get; set; }

        [Field("KESIM_EBATI")]
        [ParameterType(DbType.String)]
        public string KesimEbati { get; set; }

        [Field("IS_EBAT")]
        [ParameterType(DbType.String)]
        public string IsEbat { get; set; }

        [Field("IS_ADIM_HATTIREF")]
        [ParameterType(DbType.Int32)]
        public int? IsAdimHattiref { get; set; }

        [Field("NUSHA")]
        [ParameterType(DbType.String)]
        public string Nusha { get; set; }

        [Field("KACLIK")]
        [ParameterType(DbType.Int32)]
        public int? Kaclik { get; set; }

        [Field("NUMARATOR")]
        [ParameterType(DbType.String)]
        public string Numarator { get; set; }

        [Field("KALIP_SAYISI")]
        [ParameterType(DbType.Int32)]
        public int? KalipSayisi { get; set; }

        [Field("FORMA_SAYISI")]
        [ParameterType(DbType.String)]
        public string FormaSayisi { get; set; }

        [Field("SAYFA_SAYISI")]
        [ParameterType(DbType.Int32)]
        public int? SayfaSayisi { get; set; }

        [Field("ARTIK_SAYISI")]
        [ParameterType(DbType.Int32)]
        public int? ArtikSayisi { get; set; }

        [Field("CILT")]
        [ParameterType(DbType.String)]
        public string Cilt { get; set; }

        [Field("MONTAJ_SEKLI")]
        [ParameterType(DbType.String)]
        public string MontajSekli { get; set; }

        [Field("RENK")]
        [ParameterType(DbType.String)]
        public string Renk { get; set; }

        [Field("RENK_KATSAYISI")]
        [ParameterType(DbType.Int32)]
        public int? RenkKatsayisi { get; set; }

        [Field("CILT_SAYISI")]
        [ParameterType(DbType.Int32)]
        public int? CiltSayisi { get; set; }

        [Field("KESKI")]
        [ParameterType(DbType.String)]
        public string Keski { get; set; }

        [Field("KITAP_SAYISI")]
        [ParameterType(DbType.Int32)]
        public int? KitapSayisi { get; set; }

        [Field("TAM_FORMA_ADET")]
        [ParameterType(DbType.Decimal)]
        public decimal? TamFormaAdet { get; set; }

        [Field("TAM_FORMA_TBK")]
        [ParameterType(DbType.Decimal)]
        public decimal? TamFormaTbk { get; set; }

        [Field("YARIM_FORMA_ADET")]
        [ParameterType(DbType.Decimal)]
        public decimal? YarimFormaAdet { get; set; }

        [Field("YARIM_FORMA_TBK")]
        [ParameterType(DbType.Decimal)]
        public decimal? YarimFormaTbk { get; set; }

        [Field("CEYREK_FORMA_ADET")]
        [ParameterType(DbType.Decimal)]
        public decimal? CeyrekFormaAdet { get; set; }

        [Field("CEYREK_FORMA_TBK")]
        [ParameterType(DbType.Decimal)]
        public decimal? CeyrekFormaTbk { get; set; }

        [Field("ARTIK_FORMA_ADET")]
        [ParameterType(DbType.Decimal)]
        public decimal? ArtikFormaAdet { get; set; }

        [Field("ARTIK_FORMA_TBK")]
        [ParameterType(DbType.Decimal)]
        public decimal? ArtikFormaTbk { get; set; }

        [Field("KAPAK_FORMA_ADET")]
        [ParameterType(DbType.Decimal)]
        public decimal? KapakFormaAdet { get; set; }

        [Field("KAPAK_FORMA_TBK")]
        [ParameterType(DbType.Decimal)]
        public decimal? KapakFormaTbk { get; set; }

        [Field("KULLANILACAK_TABAKA_ADET")]
        [ParameterType(DbType.Int32)]
        public int? KullanilacakTabakaAdet { get; set; }

        [Field("TOPLAM_BASKI_ADET")]
        [ParameterType(DbType.Int32)]
        public int? ToplamBaskiAdet { get; set; }

        [Field("TOPLAM_BASILAN_TABAKA")]
        [ParameterType(DbType.Int32)]
        public int? ToplamBasilanTabaka { get; set; }

        [Field("DIKILECEK_ADET")]
        [ParameterType(DbType.Int32)]
        public int? DikilecekAdet { get; set; }

        [Field("DIKILEN_ADET")]
        [ParameterType(DbType.Int32)]
        public int? DikilenAdet { get; set; }

        [Field("KATLANACAK_ADET")]
        [ParameterType(DbType.Int32)]
        public int? KatlanacakAdet { get; set; }

        [Field("KATLANAN_ADET")]
        [ParameterType(DbType.Int32)]
        public int? KatlananAdet { get; set; }

        [Field("GRUPLANAN_ADET")]
        [ParameterType(DbType.Int32)]
        public int? GruplananAdet { get; set; }

        [Field("KASA_ADET")]
        [ParameterType(DbType.Int32)]
        public int? KasaAdet { get; set; }

        [Field("PALET")]
        [ParameterType(DbType.Int32)]
        public int? Palet { get; set; }

        [Field("A4_ADET")]
        [ParameterType(DbType.Int32)]
        public int? A4Adet { get; set; }

        [Field("WEB_ADET")]
        [ParameterType(DbType.Int32)]
        public int? WebAdet { get; set; }

        [Field("KABUL_EDILEBILIR_FIRE")]
        [ParameterType(DbType.String)]
        public string KabulEdilebilirFire { get; set; }

        [Field("KITAP_DILI_1")]
        [ParameterType(DbType.String)]
        public string KitapDili1 { get; set; }

        [Field("KITAP_DILI_2")]
        [ParameterType(DbType.String)]
        public string KitapDili2 { get; set; }

        [Field("KITAP_DILI_3")]
        [ParameterType(DbType.String)]
        public string KitapDili3 { get; set; }

        [Field("KITAP_DILI_4")]
        [ParameterType(DbType.String)]
        public string KitapDili4 { get; set; }

        [Field("KITAP_DILI_5")]
        [ParameterType(DbType.String)]
        public string KitapDili5 { get; set; }

        [Field("KITAP_DILI_6")]
        [ParameterType(DbType.String)]
        public string KitapDili6 { get; set; }

        [Field("KITAP_DILI_7")]
        [ParameterType(DbType.String)]
        public string KitapDili7 { get; set; }

        [Field("KITAP_DILI_8")]
        [ParameterType(DbType.String)]
        public string KitapDili8 { get; set; }

        [Field("KITAP_DILI_9")]
        [ParameterType(DbType.String)]
        public string KitapDili9 { get; set; }

        [Field("KITAP_DILI_10")]
        [ParameterType(DbType.String)]
        public string KitapDili10 { get; set; }

        [Field("KITAP_DILI_11")]
        [ParameterType(DbType.String)]
        public string KitapDili11 { get; set; }

        [Field("KITAP_DILI_12")]
        [ParameterType(DbType.String)]
        public string KitapDili12 { get; set; }

        [Field("KITAP_DILI_13")]
        [ParameterType(DbType.String)]
        public string KitapDili13 { get; set; }

        [Field("KITAP_DILI_14")]
        [ParameterType(DbType.String)]
        public string KitapDili14 { get; set; }

        [Field("KITAP_DILI_15")]
        [ParameterType(DbType.String)]
        public string KitapDili15 { get; set; }

        [Field("KITAP_DILI_16")]
        [ParameterType(DbType.String)]
        public string KitapDili16 { get; set; }

        [Field("KITAP_DILI_17")]
        [ParameterType(DbType.String)]
        public string KitapDili17 { get; set; }

        [Field("KITAP_DILI_18")]
        [ParameterType(DbType.String)]
        public string KitapDili18 { get; set; }

        [Field("KITAP_DILI_19")]
        [ParameterType(DbType.String)]
        public string KitapDili19 { get; set; }

        [Field("KITAP_DILI_20")]
        [ParameterType(DbType.String)]
        public string KitapDili20 { get; set; }

        [Field("KITAP_SAYFA_1")]
        [ParameterType(DbType.String)]
        public int KitapSayfa1 { get; set; }

        [Field("KITAP_SAYFA_2")]
        [ParameterType(DbType.String)]
        public int KitapSayfa2 { get; set; }

        [Field("KITAP_SAYFA_3")]
        [ParameterType(DbType.String)]
        public int KitapSayfa3 { get; set; }

        [Field("KITAP_SAYFA_4")]
        [ParameterType(DbType.Int32)]
        public int KitapSayfa4 { get; set; }

        [Field("KITAP_SAYFA_5")]
        [ParameterType(DbType.Int32)]
        public int KitapSayfa5 { get; set; }

        [Field("KITAP_SAYFA_6")]
        [ParameterType(DbType.Int32)]
        public int KitapSayfa6 { get; set; }

        [Field("KITAP_SAYFA_7")]
        [ParameterType(DbType.Int32)]
        public int KitapSayfa7 { get; set; }

        [Field("KITAP_SAYFA_8")]
        [ParameterType(DbType.Int32)]
        public int KitapSayfa8 { get; set; }

        [Field("KITAP_SAYFA_9")]
        [ParameterType(DbType.Int32)]
        public int KitapSayfa9 { get; set; }

        [Field("KITAP_SAYFA_10")]
        [ParameterType(DbType.Int32)]
        public int KitapSayfa10 { get; set; }

        [Field("KITAP_SAYFA_11")]
        [ParameterType(DbType.Int32)]
        public int KitapSayfa11 { get; set; }

        [Field("KITAP_SAYFA_12")]
        [ParameterType(DbType.Int32)]
        public int KitapSayfa12 { get; set; }

        [Field("KITAP_SAYFA_13")]
        [ParameterType(DbType.Int32)]
        public int KitapSayfa13 { get; set; }

        [Field("KITAP_SAYFA_14")]
        [ParameterType(DbType.Int32)]
        public int KitapSayfa14 { get; set; }

        [Field("KITAP_SAYFA_15")]
        [ParameterType(DbType.Int32)]
        public int KitapSayfa15 { get; set; }

        [Field("KITAP_SAYFA_16")]
        [ParameterType(DbType.Int32)]
        public int KitapSayfa16 { get; set; }

        [Field("KITAP_SAYFA_17")]
        [ParameterType(DbType.Int32)]
        public int KitapSayfa17 { get; set; }

        [Field("KITAP_SAYFA_18")]
        [ParameterType(DbType.Int32)]
        public int KitapSayfa18 { get; set; }

        [Field("KITAP_SAYFA_19")]
        [ParameterType(DbType.Int32)]
        public int KitapSayfa19 { get; set; }

        [Field("KITAP_SAYFA_20")]
        [ParameterType(DbType.Int32)]
        public int KitapSayfa20 { get; set; }

        [Field("IS_IMPORTANT")]
        [ParameterType(DbType.Int32)]
        public int? IsImportant { get; set; }

        [Field("IS_CUSTOMER_WAITING")]
        [ParameterType(DbType.Int32)]
        public int? IsCustomerWaiting { get; set; }

        [Field("IS_FAULT_WORK")]
        [ParameterType(DbType.Boolean)]
        public bool? IsFaultWork { get; set; }

        [Field("ISREVIZYON")]
        [ParameterType(DbType.Int32)]
        public int IsRevizyon { get; set; }

        [Field("REVIZYON")]
        [ParameterType(DbType.Int32)]
        public int Revizyon { get; set; }

        [Field("REPEAT")]
        [ParameterType(DbType.Int32)]
        public int Repeat { get; set; }

        [Field("REVIZYON_TIPI")]
        [ParameterType(DbType.String)]
        public string RevizyonTipi { get; set; }

        [Field("REVIZYON_TARIHI")]
        [ParameterType(DbType.DateTime)]
        public DateTime? RevizyonTarihi { get; set; }

        [Field("REVIZYON_NOT")]
        [ParameterType(DbType.String)]
        public string RevizyonNot { get; set; }

        [Field("ISCURRENT")]
        [ParameterType(DbType.Int32)]
        public int Iscurrent { get; set; }

        [Field("ISWORKORDERCREATED")]
        [ParameterType(DbType.Int32)]
        public int Isworkordercreated { get; set; }

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

        [Field("FIRMA")]
        [ParameterType(DbType.String)]
        public string Firma { get; set; }

        [Field("FIRMAREVIZYON")]
        [ParameterType(DbType.String)]
        public string FirmaRevizyon { get; set; }

        [Field("LINESTATUS")]
        [ParameterType(DbType.Int32)]
        public int? Linestatus { get; set; }

        [Field("PRINTCOUNT")]
        [ParameterType(DbType.Int32)]
        public int? Printcount { get; set; }

        [Field("ISLAKVAR")]
        [ParameterType(DbType.Int32)]
        public int? Islakvar { get; set; }

        [Field("ISVERNIKVAR")]
        [ParameterType(DbType.Int32)]
        public int? Isvernikvar { get; set; }

        [Field("ISSELEFONVAR")]
        [ParameterType(DbType.Int32)]
        public int? Isselefonvar { get; set; }

        [Field("ISPVCVAR")]
        [ParameterType(DbType.Int32)]
        public int? Ispvcvar { get; set; }

        [Field("MUSTERIREVIZYONNO")]
        [ParameterType(DbType.String)]
        public string MusteriRevizyonNo{ get; set; }

        [Field("MUSTERISIPARISNO")]
        [ParameterType(DbType.String)]
        public string Musterisiparisno { get; set; }

        [Field("MUSTERIURUNKODU")]
        [ParameterType(DbType.String)]
        public string MusteriUrunKodu { get; set; }

        [Field("BOBINENI")]
        [ParameterType(DbType.Int32)]
        public int? Bobineni { get; set; }

        [Field("BOBINUZUNLUGU")]
        [ParameterType(DbType.Int32)]
        public int? Bobinuzunlugu { get; set; }

        [Field("MARKPAYI")]
        [ParameterType(DbType.Int32)]
        public int? Markpayý { get; set; }

        [Field("KOMBINBILGISI")]
        [ParameterType(DbType.Decimal)]
        public decimal? Kombinbilgisi { get; set; }

        [Field("KOMBINEBAT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Kombinebat { get; set; }

        [Field("KOMBINADET")]
        [ParameterType(DbType.Decimal)]
        public decimal? Kombinadet { get; set; }

        [Field("KOMBINAKISBOYU")]
        [ParameterType(DbType.Decimal)]
        public decimal? Kombinakisboyu { get; set; }

        [Field("ICKAGIT_AMOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Ickagitiamount { get; set; }

        [Field("KAPAKKAGIT_AMOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Kapakkagitamount { get; set; }

        #endregion

    }
}
