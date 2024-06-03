using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// WMS_TRANSORDERLINE için base classý
    /// </summary>
    [Serializable]
    [TableName("WMS_TRANSORDERLINE")]
    public class WmsTransorderline : BaseModel
    {

        #region Constructor

        public WmsTransorderline()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("WmsTransorderline_seq")]
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

        [Field("BEGDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Begdate { get; set; }

        [Field("ENDDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Enddate { get; set; }

        [Field("ISCOMPLETED")]
        [ParameterType(DbType.Int32)]
        public int? Iscompleted { get; set; }

        [Field("WMSMOVELINEREF")]
        [ParameterType(DbType.Int32)]
        public int? Wmsmovelineref { get; set; }

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
