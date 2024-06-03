using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// WMS_ITEMBARCODE için base classý
    /// </summary>
    [Serializable]
    [TableName("WMS_ITEMBARCODE")]
    public class WmsItembarcode : BaseModel
    {

        #region Constructor

        public WmsItembarcode()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("WmsItembarcode_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("BARCODE")]
        [ParameterType(DbType.String)]
        public string Barcode { get; set; }

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

        [Field("UOMREF")]
        [ParameterType(DbType.Int32)]
        public int? Uomref { get; set; }

        [Field("CONVFACT1")]
        [ParameterType(DbType.Int32)]
        public int? Convfact1 { get; set; }

        [Field("CONVFACT2")]
        [ParameterType(DbType.Int32)]
        public int? Convfact2 { get; set; }

        [Field("WIDTH")]
        [ParameterType(DbType.Decimal)]
        public decimal? Width { get; set; }

        [Field("LENGTH")]
        [ParameterType(DbType.Decimal)]
        public decimal? Length { get; set; }

        [Field("HEIGHT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Height { get; set; }

        [Field("AREA")]
        [ParameterType(DbType.Decimal)]
        public decimal? Area { get; set; }

        [Field("VOLUME")]
        [ParameterType(DbType.Decimal)]
        public decimal? Volume { get; set; }

        [Field("WEIGHT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Weight { get; set; }

        [Field("CLIENTLOTNO")]
        [ParameterType(DbType.String)]
        public string Clientlotno { get; set; }

        [Field("SKT")]
        [ParameterType(DbType.Date)]
        public DateTime? Skt { get; set; }

        [Field("PRODUCTIONDATE")]
        [ParameterType(DbType.Date)]
        public DateTime? Productiondate { get; set; }

        [Field("TRCODE")]
        [ParameterType(DbType.Int32)]
        public int? Trcode { get; set; }

        [Field("ISFINISHED")]
        [ParameterType(DbType.Int32)]
        public int? Isfinished { get; set; }

        [Field("CREATEDAT")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Createdat { get; set; }

        [Field("CREATEDBY")]
        [ParameterType(DbType.Int32)]
        public int? Createdby { get; set; }

        [Field("CHANGEDAT")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Changedat { get; set; }

        [Field("CHANGEDBY")]
        [ParameterType(DbType.Int32)]
        public int? Changedby { get; set; }

        #endregion

    }
}
