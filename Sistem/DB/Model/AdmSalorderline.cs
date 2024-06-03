using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_SALORDERLINE için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_SALORDERLINE")]
    public class AdmSalorderline : BaseModel
    {

        #region Constructor

        public AdmSalorderline()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmSalorderline_seq")]
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

        [Field("QUANTITY")]
        [ParameterType(DbType.Decimal)]
        public decimal? Quantity { get; set; }

        [Field("UNIT")]
        [ParameterType(DbType.String)]
        public string Unit { get; set; }

        [Field("PRICE")]
        [ParameterType(DbType.Decimal)]
        public decimal? Price { get; set; }

        [Field("TOTAL")]
        [ParameterType(DbType.Decimal)]
        public decimal? Total { get; set; }

        [Field("ISCOMPLETED")]
        [ParameterType(DbType.Int32)]
        public int? Iscompleted { get; set; }

        [Field("CREATEDAT")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Createdat { get; set; }

        [Field("CREATEDBY")]
        [ParameterType(DbType.String)]
        public string Createdby { get; set; }

        [Field("CHANGEDAT")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Changedat { get; set; }

        [Field("CHANGEDBY")]
        [ParameterType(DbType.String)]
        public string Changedby { get; set; }

        [Field("LINEEXP")]
        [ParameterType(DbType.String)]
        public string Lineexp { get; set; }

        [Field("COLOR")]
        [ParameterType(DbType.String)]
        public string Color { get; set; }

        [Field("GRAMAJ")]
        [ParameterType(DbType.Decimal)]
        public decimal? Gramaj { get; set; }

        #endregion

    }
}
