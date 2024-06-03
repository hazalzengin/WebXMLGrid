using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_RETAIL_SALEITEMS için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_RETAIL_SALEITEMS")]
    public class AdmRetailSaleitems : BaseModel
    {

        #region Constructor

        public AdmRetailSaleitems()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmRetailSaleitems_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("REATILSALEREF")]
        [ParameterType(DbType.Int32)]
        public int? Reatilsaleref { get; set; }

        [Field("ITEMCODE")]
        [ParameterType(DbType.String)]
        public string Itemcode { get; set; }

        [Field("ITEMNAME")]
        [ParameterType(DbType.String)]
        public string Itemname { get; set; }

        [Field("AMOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Amount { get; set; }

        [Field("UNIT")]
        [ParameterType(DbType.String)]
        public string Unit { get; set; }

        [Field("UNITPRICE")]
        [ParameterType(DbType.Decimal)]
        public decimal? Unitprice { get; set; }

        [Field("CURRENCY")]
        [ParameterType(DbType.String)]
        public string Currency { get; set; }

        [Field("CURRENCYRATE")]
        [ParameterType(DbType.Decimal)]
        public decimal? Currencyrate { get; set; }

        [Field("VAT")]
        [ParameterType(DbType.Int32)]
        public int? Vat { get; set; }

        [Field("VATTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Vattype { get; set; }

        [Field("DISCOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Discount { get; set; }

        [Field("EXPCTGNO")]
        [ParameterType(DbType.Decimal)]
        public decimal? Expctgno { get; set; }

        [Field("EXP1")]
        [ParameterType(DbType.String)]
        public string Exp1 { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
