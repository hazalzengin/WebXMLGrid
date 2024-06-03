using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_EDC_OFFERITEMS için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_EDC_OFFERITEMS")]
    public class AdmEdcOfferitems : BaseModel
    {

        #region Constructor

        public AdmEdcOfferitems()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmEdcOfferitems_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("OFFERREF")]
        [ParameterType(DbType.Int32)]
        public int? Offerref { get; set; }

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

        [Field("UNIT")]
        [ParameterType(DbType.String)]
        public string Unit { get; set; }

        [Field("UNITPRICE")]
        [ParameterType(DbType.Decimal)]
        public decimal? Unitprice { get; set; }

        [Field("UNITPRICECUR")]
        [ParameterType(DbType.Decimal)]
        public decimal? Unitpricecur { get; set; }

        [Field("CURRENCYTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Currencytype { get; set; }

        [Field("CURRENCYRATE")]
        [ParameterType(DbType.Decimal)]
        public decimal? Currencyrate { get; set; }

        [Field("VATRATE")]
        [ParameterType(DbType.Decimal)]
        public decimal? Vatrate { get; set; }

        [Field("VATTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Vattype { get; set; }

        [Field("DISCOUNT1")]
        [ParameterType(DbType.Decimal)]
        public decimal? Discount1 { get; set; }

        [Field("DISCOUNT2")]
        [ParameterType(DbType.Decimal)]
        public decimal? Discount2 { get; set; }

        [Field("DISCOUNT3")]
        [ParameterType(DbType.Decimal)]
        public decimal? Discount3 { get; set; }

        [Field("WAREHOUSECODE")]
        [ParameterType(DbType.String)]
        public string Warehousecode { get; set; }

        [Field("WAREHOUSENAME")]
        [ParameterType(DbType.String)]
        public string Warehousename { get; set; }

        [Field("EXP1")]
        [ParameterType(DbType.String)]
        public string Exp1 { get; set; }

        [Field("EXP2")]
        [ParameterType(DbType.String)]
        public string Exp2 { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
