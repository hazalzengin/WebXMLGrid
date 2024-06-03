using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// WMS_TEMP_SHIPORDERLINE için base classý
    /// </summary>
    [Serializable]
    [TableName("WMS_TEMP_SHIPORDERLINE")]
    public class WmsTempShiporderline : BaseModel
    {

        #region Constructor

        public WmsTempShiporderline()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("WmsTempShiporderline_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("ORDERREF")]
        [ParameterType(DbType.Int32)]
        public int? Orderref { get; set; }

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

        [Field("BRANCH")]
        [ParameterType(DbType.Int32)]
        public int? Branch { get; set; }

        [Field("SOURCEINDEX")]
        [ParameterType(DbType.Int32)]
        public int? Sourceindex { get; set; }

        [Field("LOCATIONREF")]
        [ParameterType(DbType.Int32)]
        public int? Locationref { get; set; }

        [Field("ISTRANSFERRED")]
        [ParameterType(DbType.Int32)]
        public int? Istransferred { get; set; }

        #endregion

    }
}
