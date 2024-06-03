using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_PRDORDER için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_PRDORDER")]
    public class AdmPrdorder : BaseModel
    {

        #region Constructor

        public AdmPrdorder()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmPrdorder_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Date_ { get; set; }

        [Field("STARTDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Startdate { get; set; }

        [Field("ENDDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Enddate { get; set; }

        [Field("CODE")]
        [ParameterType(DbType.String)]
        public string Code { get; set; }

        [Field("NAME")]
        [ParameterType(DbType.String)]
        public string Name { get; set; }

        [Field("PRDTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Prdtype { get; set; }

        [Field("ROUREF")]
        [ParameterType(DbType.Int32)]
        public int? Rouref { get; set; }

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

        [Field("WAREHOUSECODE")]
        [ParameterType(DbType.String)]
        public string Warehousecode { get; set; }

        [Field("WAREHOUSENAME")]
        [ParameterType(DbType.String)]
        public string Warehousename { get; set; }

        [Field("ISCOLLECTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Iscollective { get; set; }

        [Field("LOTNUM")]
        [ParameterType(DbType.String)]
        public string Lotnum { get; set; }

        [Field("ISSTART")]
        [ParameterType(DbType.Int32)]
        public int? Isstart { get; set; }

        [Field("ISCONFIRMED")]
        [ParameterType(DbType.Int32)]
        public int? Isconfirmed { get; set; }

        [Field("ISCOMPLETED")]
        [ParameterType(DbType.Int32)]
        public int? Iscompleted { get; set; }

        [Field("TOTALOUTPUT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Totaloutput { get; set; }

        [Field("TOTALSCRAP")]
        [ParameterType(DbType.Decimal)]
        public decimal? Totalscrap { get; set; }

        [Field("PROJECTNO")]
        [ParameterType(DbType.String)]
        public string Projectno { get; set; }

        [Field("COSTCENTER")]
        [ParameterType(DbType.String)]
        public string Costcenter { get; set; }

        [Field("SALNUM")]
        [ParameterType(DbType.String)]
        public string Salnum { get; set; }

        [Field("CUSTOMERCODE")]
        [ParameterType(DbType.String)]
        public string Customercode { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        [Field("EXP")]
        [ParameterType(DbType.String)]
        public string Exp { get; set; }

        [Field("ISITEMTRANSFERREDTOWH")]
        [ParameterType(DbType.Int32)]
        public int? Isitemtransferredtowh { get; set; }

        [Field("ISITEMTRANSFERREDTOWHMSG")]
        [ParameterType(DbType.String)]
        public string Isitemtransferredtowhmsg { get; set; }

        [Field("ISITEMLOTSELECTED")]
        [ParameterType(DbType.Int32)]
        public int? Isitemlotselected { get; set; }

        [Field("HMWH_FROMREF")]
        [ParameterType(DbType.Int32)]
        public int? HmwhFromref { get; set; }

        [Field("HMWH_FROMCODE")]
        [ParameterType(DbType.String)]
        public string HmwhFromcode { get; set; }

        [Field("HMWH_FROMNAME")]
        [ParameterType(DbType.String)]
        public string HmwhFromname { get; set; }

        [Field("HMWH_TOREF")]
        [ParameterType(DbType.Int32)]
        public int? HmwhToref { get; set; }

        [Field("HMWH_TOCODE")]
        [ParameterType(DbType.String)]
        public string HmwhTocode { get; set; }

        [Field("HMWH_TONAME")]
        [ParameterType(DbType.String)]
        public string HmwhToname { get; set; }

        [Field("ISCANCELLED")]
        [ParameterType(DbType.Int32)]
        public int? Iscancelled { get; set; }

        [Field("CANCELMESSAGE")]
        [ParameterType(DbType.String)]
        public string Cancelmessage { get; set; }

        [Field("CANCELLEDBY")]
        [ParameterType(DbType.String)]
        public string Cancelledby { get; set; }

        [Field("CANCELDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Canceldate { get; set; }

        [Field("BOBINCAPI")]
        [ParameterType(DbType.Int32)]
        public int? Bobincapi { get; set; }

        [Field("EKYERIBANDI")]
        [ParameterType(DbType.String)]
        public string Ekyeribandi { get; set; }

        [Field("VENTIL")]
        [ParameterType(DbType.Int32)]
        public int? Ventil { get; set; }

        [Field("EKYERISAYISI")]
        [ParameterType(DbType.Int32)]
        public int? Ekyerisayisi { get; set; }

        [Field("PALETLEME")]
        [ParameterType(DbType.Int32)]
        public int? Paletleme { get; set; }

        [Field("SARIMSAYISI")]
        [ParameterType(DbType.Int32)]
        public int? SarimSayisi { get; set; }

        [Field("TOPLAMDILIMSAYISI")]
        [ParameterType(DbType.Int32)]
        public int? ToplamDilimSayisi { get; set; }

        [Field("PALETSAYISI")]
        [ParameterType(DbType.Int32)]
        public int? PaletSayisi { get; set; }

        [Field("PALETICIDILIMSAYISI")]
        [ParameterType(DbType.Int32)]
        public int? Paleticidilimsayisi { get; set; }

        [Field("METRAJ")]
        [ParameterType(DbType.Decimal)]
        public decimal? Metraj { get; set; }

        [Field("DARA")]
        [ParameterType(DbType.Decimal)]
        public decimal? Dara { get; set; }

        [Field("ETIKETTIPI")]
        [ParameterType(DbType.Int32)]
        public int? Etikettipi { get; set; }

        [Field("PRDDESIGNREF")]
        [ParameterType(DbType.Int32)]
        public int? PrdDesignRef { get; set; }

        [Field("WMSDESIGNREF")]
        [ParameterType(DbType.Int32)]
        public int? WmsDesignRef { get; set; }


        [Field("CUSTOMERNAME")]
        [ParameterType(DbType.String)]
        public string Customername { get; set; }

        [Field("OFFERITEMREF")]
        [ParameterType(DbType.Int32)]
        public int? Offeritemref { get; set; }

        [Field("MAINORDERREF")]
        [ParameterType(DbType.Int32)]
        public int? MainOrderRef{ get; set; }
        #endregion

    }
}
