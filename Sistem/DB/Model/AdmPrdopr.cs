using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_PRDOPR için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_PRDOPR")]
    public class AdmPrdopr : BaseModel
    {

        #region Constructor

        public AdmPrdopr()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmPrdopr_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("TYPE")]
        [ParameterType(DbType.Int32)]
        public int? Type { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Date_ { get; set; }

        [Field("STARTDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Startdate { get; set; }

        [Field("ENDDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Enddate { get; set; }

        [Field("ORDERREF")]
        [ParameterType(DbType.Int32)]
        public int Orderref { get; set; }

        [Field("OPRNUM")]
        [ParameterType(DbType.String)]
        public string Oprnum { get; set; }

        [Field("CODE")]
        [ParameterType(DbType.String)]
        public string Code { get; set; }

        [Field("NAME")]
        [ParameterType(DbType.String)]
        public string Name { get; set; }


        [Field("ITEMREF")]
        [ParameterType(DbType.Int32)]
        public int? Itemref { get; set; }

        [Field("ITEMCODE")]
        [ParameterType(DbType.String)]
        public string Itemcode { get; set; }

        [Field("ITEMNAME")]
        [ParameterType(DbType.String)]
        public string Itemname { get; set; }

        [Field("QUANTITY")]
        [ParameterType(DbType.Decimal)]
        public decimal? Quantity { get; set; }

        [Field("QUNIT")]
        [ParameterType(DbType.String)]
        public string Qunit { get; set; }

        [Field("WAREHOUSEREF")]
        [ParameterType(DbType.Int32)]
        public int? Warehouseref { get; set; }
        [Field("WAREHOUSENAME")]
        [ParameterType(DbType.String)]
        public string Warehousename { get; set; }

        [Field("PERSONNELREF")]
        [ParameterType(DbType.Int32)]
        public int? Personnelref { get; set; }

        [Field("SHIFTREF")]
        [ParameterType(DbType.Int32)]
        public int? Shiftref { get; set; }

        [Field("ISFIRST")]
        [ParameterType(DbType.Int32)]
        public int? Isfirst { get; set; }

        [Field("NEXTOPRNUM")]
        [ParameterType(DbType.Int32)]
        public int? Nextoprnum { get; set; }

        [Field("ISLAST")]
        [ParameterType(DbType.Int32)]
        public int? Islast { get; set; }

        [Field("PRODUCED")]
        [ParameterType(DbType.Decimal)]
        public decimal? Produced { get; set; }

        [Field("SCRAPAMOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Scrapamount { get; set; }

        [Field("WORKCENTER")]
        [ParameterType(DbType.Int32)]
        public int? Workcenter { get; set; }

        [Field("EXP")]
        [ParameterType(DbType.String)]
        public string Exp { get; set; }

        [Field("SETUPTIME")]
        [ParameterType(DbType.String)]
        public string Setuptime { get; set; }

        [Field("BREAKTIME")]
        [ParameterType(DbType.String)]
        public string Breaktime { get; set; }

        [Field("ACTIVITYTIME")]
        [ParameterType(DbType.String)]
        public string Activitytime { get; set; }

        [Field("LABOURTIME")]
        [ParameterType(DbType.String)]
        public string Labourtime { get; set; }

        [Field("ISCALCUL")]
        [ParameterType(DbType.Int32)]
        public int? Iscalcul { get; set; }

        [Field("ISFINISHED")]
        [ParameterType(DbType.Int32)]
        public int? Isfinished { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        [Field("TRANSFERSTATUS")]
        [ParameterType(DbType.Int32)]
        public int? Transferstatus { get; set; }

        [Field("TRANSFERMESSAGE")]
        [ParameterType(DbType.String)]
        public string Transfermessage { get; set; }

        [Field("LOTNUM")]
        [ParameterType(DbType.String)]
        public string Lotnum { get; set; }

        [Field("LOTSKT")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Lotskt { get; set; }

        [Field("PALETTEQUANTITY")]
        [ParameterType(DbType.Int32)]
        public int? Palettequantity { get; set; }

        [Field("PANQUANTITY")]
        [ParameterType(DbType.Int32)]
        public int? Panquantity { get; set; }

        [Field("BAGQUANTITY")]
        [ParameterType(DbType.Int32)]
        public int? Bagquantity { get; set; }

        [Field("METRAJ")]
        [ParameterType(DbType.Decimal)]
        public decimal? Metraj { get; set; }

        [Field("EKYERIMETRAJ")]
        [ParameterType(DbType.String)]
        public string EkyeriMetraj { get; set; }

        [Field("EKYERISAYISI")]
        [ParameterType(DbType.Decimal)]
        public decimal? EkyeriSayisi { get; set; }

        [Field("JUMBO")]
        [ParameterType(DbType.Int32)]
        public int? Jumbo { get; set; }

        [Field("BOBIN")]
        [ParameterType(DbType.Int32)]
        public int? Bobin { get; set; }

        [Field("DILIMSAYISI")]
        [ParameterType(DbType.Int32)]
        public int? DilimSayisi { get; set; }

        [Field("IKINCIKALITEMALZEMEKODU")]
        [ParameterType(DbType.String)]
        public string IkinciKaliteMalzemeKodu { get; set; }

        [Field("IKINCIKALITEURETILEN")]
        [ParameterType(DbType.Decimal)]
        public decimal? IkinciKaliteUretilen { get; set; }

        [Field("HURDAMIKTARI")]
        [ParameterType(DbType.Decimal)]
        public decimal? HurdaMiktari { get; set; }

        [Field("DOKUMNO")]
        [ParameterType(DbType.String)]
        public string DokumNo { get; set; }

        [Field("PRDITEMWH")]
        [ParameterType(DbType.Int32)]
        public int? Prditemwh { get; set; }

        [Field("PRDITEMWHNAME")]
        [ParameterType(DbType.String)]
        public string Prditemwhname { get; set; }

        [Field("PRDITEMSHELF")]
        [ParameterType(DbType.Int32)]
        public int? Prditemshelf { get; set; }

        [Field("PRDITEMSHELFNAME")]
        [ParameterType(DbType.String)]
        public string Prditemshelfname { get; set; }

        [Field("SUPPLYITEMWH")]
        [ParameterType(DbType.Int32)]
        public int? Supplyitemwh { get; set; }

        [Field("SUPPLYITEMWHNAME")]
        [ParameterType(DbType.String)]
        public string Supplyitemwhname { get; set; }

        [Field("SUPPLYITEMSHELF")]
        [ParameterType(DbType.Int32)]
        public int? Supplyitemshelf { get; set; }

        [Field("SUPPLYITEMSHELFNAME")]
        [ParameterType(DbType.String)]
        public string Supplyitemshelfname { get; set; }

        [Field("SACTIVITY")]
        [ParameterType(DbType.Int32)]
        public int? Sactivity { get; set; }

        [Field("SACTIVITYNAME")]
        [ParameterType(DbType.String)]
        public string Sactivityname { get; set; }

        [Field("SCOSTTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Scosttype { get; set; }

        [Field("SISCOST")]
        [ParameterType(DbType.Int32)]
        public int? Siscost { get; set; }

        [Field("STIMEUNIT")]
        [ParameterType(DbType.Int32)]
        public int? Stimeunit { get; set; }

        [Field("MACTIVITY")]
        [ParameterType(DbType.Int32)]
        public int? Mactivity { get; set; }

        [Field("MACTIVITYNAME")]
        [ParameterType(DbType.String)]
        public string Mactivityname { get; set; }

        [Field("MCOSTTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Mcosttype { get; set; }

        [Field("MISCOST")]
        [ParameterType(DbType.Int32)]
        public int? Miscost { get; set; }

        [Field("MTIMEUNIT")]
        [ParameterType(DbType.Int32)]
        public int? Mtimeunit { get; set; }

        [Field("LACTIVITY")]
        [ParameterType(DbType.Int32)]
        public int? Lactivity { get; set; }

        [Field("LACTIVITYNAME")]
        [ParameterType(DbType.String)]
        public string Lactivityname { get; set; }

        [Field("LCOSTTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Lcosttype { get; set; }

        [Field("LISCOST")]
        [ParameterType(DbType.Int32)]
        public int? Liscost { get; set; }

        [Field("LTIMEUNIT")]
        [ParameterType(DbType.Int32)]
        public int? Ltimeunit { get; set; }

        [Field("CONFIRMNO")]
        [ParameterType(DbType.Int32)]
        public int? Confirmno { get; set; }

        [Field("CONFIRMSTATUS")]
        [ParameterType(DbType.Int32)]
        public int? Confirmstatus { get; set; }

        [Field("ISSTART")]
        [ParameterType(DbType.Int32)]
        public int? Isstart { get; set; }

        [Field("ERPPRODREF")]
        [ParameterType(DbType.Int32)]
        public int? Erpprodref { get; set; }

        [Field("ERPCONSREF")]
        [ParameterType(DbType.Int32)]
        public int? Erpconsref { get; set; }

        [Field("ISQLTREQ")]
        [ParameterType(DbType.Int32)]
        public int? Isqltreq { get; set; }

        [Field("QLTAPPROVEDSTATUS")]
        [ParameterType(DbType.Int32)]
        public int? Qltapprovedstatus { get; set; }

        [Field("IZLENEBILIRLIKNO")]
        [ParameterType(DbType.String)]
        public string IzlenebilirlikNo { get; set; }

        [Field("TARTIMASAMASI_DATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? TartimAsamasi { get; set; }

        [Field("IPKKONTROL_DATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? IpkKontrol { get; set; }

        [Field("URETIMASAMASI_DATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? UretimAsamasi { get; set; }

        [Field("DOLUMASAMASI_DATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? DolumAsamasi { get; set; }

        [Field("AMBALAJLAMAASAMASI_DATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? AmbalajlamaAsamasi { get; set; }

        [Field("FIRENEDENI")]
        [ParameterType(DbType.String)]
        public string FireNedeni { get; set; }
        #endregion

    }
}
