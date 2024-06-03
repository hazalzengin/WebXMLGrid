using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_PRDITEM için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_PRDITEM")]
    public class AdmPrditem : BaseModel
    {

        #region Constructor

        public AdmPrditem()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmPrditem_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("OPRREF")]
        [ParameterType(DbType.Int32)]
        public int Oprref { get; set; }

        [Field("ORDERREF")]
        [ParameterType(DbType.Int32)]
        public int Orderref { get; set; }

        [Field("ITEMTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Itemtype { get; set; }

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

        [Field("LOTNUM")]
        [ParameterType(DbType.String)]
        public string Lotnum { get; set; }

        [Field("PRODUCED")]
        [ParameterType(DbType.Decimal)]
        public decimal? Produced { get; set; } 
        [Field("SUBSCRAP")]
        [ParameterType(DbType.Decimal)]
        public decimal? Subscrap { get; set; }

        [Field("ISPRODUCED")]
        [ParameterType(DbType.Int32)]
        public int? Isproduced { get; set; }

        [Field("TRACKTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Tracktype { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
