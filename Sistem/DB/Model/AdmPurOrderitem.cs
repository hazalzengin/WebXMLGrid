using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_PUR_ORDERITEM için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_PUR_ORDERITEM")]
    public class AdmPurOrderitem : BaseModel
    {

        #region Constructor

        public AdmPurOrderitem()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmPurOrderitem_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("ORDERREF")]
        [ParameterType(DbType.Int32)]
        public int? Orderref { get; set; }

        [Field("ITEMREF")]
        [ParameterType(DbType.Int32)]
        public int? Itemref { get; set; }

        [Field("ITEMCODE")]
        [ParameterType(DbType.String)]
        public string Itemcode { get; set; }

        [Field("ITEMNAME")]
        [ParameterType(DbType.String)]
        public string Itemname { get; set; }

        [Field("UNIT")]
        [ParameterType(DbType.String)]
        public string Unit { get; set; }

        [Field("QUANTITY")]
        [ParameterType(DbType.Decimal)]
        public decimal? Quantity { get; set; }

        [Field("UNITPRICE")]
        [ParameterType(DbType.Decimal)]
        public decimal? Unitprice { get; set; }

        [Field("VATTYPE")]
        [ParameterType(DbType.String)]
        public string Vattype { get; set; }

        [Field("VATRATE")]
        [ParameterType(DbType.Decimal)]
        public decimal? Vatrate { get; set; }

        [Field("CURRENCY")]
        [ParameterType(DbType.String)]
        public string Currency { get; set; }

        [Field("DUEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Duedate { get; set; }

        [Field("EXP")]
        [ParameterType(DbType.String)]
        public string Exp { get; set; }

        [Field("LASTPURPRICE")]
        [ParameterType(DbType.Decimal)]
        public decimal? LastPurPrice { get; set; }

        #endregion

    }
}
