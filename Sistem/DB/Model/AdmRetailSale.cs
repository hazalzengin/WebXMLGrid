using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_RETAIL_SALE için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_RETAIL_SALE")]
    public class AdmRetailSale : BaseModel
    {

        #region Constructor

        public AdmRetailSale()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmRetailSale_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Date_ { get; set; }

        [Field("LG_CLCARDREF")]
        [ParameterType(DbType.Int32)]
        public int? LgClcardref { get; set; }

        [Field("LG_CLCARDDEF")]
        [ParameterType(DbType.String)]
        public string LgClcarddef { get; set; }

        [Field("PAYMENTTYPE")]
        [ParameterType(DbType.String)]
        public string Paymenttype { get; set; }

        [Field("TRADINGGRP")]
        [ParameterType(DbType.String)]
        public string Tradinggrp { get; set; }


        [Field("DISCOUNT1")]
        [ParameterType(DbType.Decimal)]
        public decimal? Discount1 { get; set; }

        [Field("DISCOUNT2")]
        [ParameterType(DbType.Decimal)]
        public decimal? Discount2 { get; set; }

        [Field("DISCOUNT3")]
        [ParameterType(DbType.Decimal)]
        public decimal? Discount3 { get; set; }

        [Field("EXP1")]
        [ParameterType(DbType.String)]
        public string Exp1 { get; set; }

        [Field("STATUS")]
        [ParameterType(DbType.Int32)]
        public int? Status { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
