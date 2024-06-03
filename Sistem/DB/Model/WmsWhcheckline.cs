using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// WMS_WHCHECKLINE için base classý
    /// </summary>
    [Serializable]
    [TableName("WMS_WHCHECKLINE")]
    public class WmsWhcheckline : BaseModel
    {

        #region Constructor

        public WmsWhcheckline()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("WmsWhcheckline_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("HEADREF")]
        [ParameterType(DbType.Int32)]
        public int? Headref { get; set; }

        [Field("ITEMREF")]
        [ParameterType(DbType.Int32)]
        public int? Itemref { get; set; }

        [Field("ITEMCODE")]
        [ParameterType(DbType.String)]
        public string Itemcode { get; set; }

        [Field("ITEMNAME")]
        [ParameterType(DbType.String)]
        public string Itemname { get; set; }

        [Field("BARCODE")]
        [ParameterType(DbType.String)]
        public string Barcode { get; set; }

        [Field("LOCATION")]
        [ParameterType(DbType.Int32)]
        public int? Location { get; set; }

        [Field("UOMREF")]
        [ParameterType(DbType.Int32)]
        public int? Uomref { get; set; }

        [Field("CONVFACT1")]
        [ParameterType(DbType.Int32)]
        public int? Convfact1 { get; set; }

        [Field("CONVFACT2")]
        [ParameterType(DbType.Int32)]
        public int? Convfact2 { get; set; }

        [Field("CURRAMOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Curramount { get; set; }

        [Field("COUNTEDAMOUNTED")]
        [ParameterType(DbType.Decimal)]
        public decimal? Countedamounted { get; set; }

        [Field("DIFFAMOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Diffamount { get; set; }

        [Field("ISCOMPLETED")]
        [ParameterType(DbType.Int32)]
        public int? Iscompleted { get; set; }

        [Field("MOVELINEREF")]
        [ParameterType(DbType.Int32)]
        public int? Movelineref { get; set; }

        [Field("ISNEW")]
        [ParameterType(DbType.Int32)]
        public int? Isnew { get; set; }

        [Field("CREATEDAT")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Createdat { get; set; }

        [Field("CREATEDBY")]
        [ParameterType(DbType.String)]
        public String Createdby { get; set; }

        [Field("CHANGEDAT")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Changedat { get; set; }

        [Field("CHANGEDBY")]
        [ParameterType(DbType.String)]
        public String Changedby { get; set; }

        #endregion

    }
}
