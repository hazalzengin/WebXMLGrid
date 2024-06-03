using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_ERDR_OFFERITEMS için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_ERDR_OFFERITEMS")]
    public class AdmErdrOfferitemstmp : BaseModel
    {

        #region Constructor

        public AdmErdrOfferitemstmp()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmErdrOfferitems_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("OFFERREF")]
        [ParameterType(DbType.Int32)]
        public int? Offerref { get; set; }

        [Field("ITEMTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Itemtype { get; set; }

        [Field("STOCKNAME")]
        [ParameterType(DbType.String)]
        public string Stockname { get; set; }

        [Field("HASACCESSORY")]
        [ParameterType(DbType.Int32)]
        public int? Hasaccessory { get; set; }

        [Field("STOCKREF")]
        [ParameterType(DbType.Int32)]
        public int? Stockref { get; set; }

        [Field("AMOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Amount { get; set; }

        [Field("UNIT")]
        [ParameterType(DbType.String)]
        public string Unit { get; set; }

        [Field("PRICE")]
        [ParameterType(DbType.Decimal)]
        public decimal? Price { get; set; }

        [Field("CURRENCY")]
        [ParameterType(DbType.String)]
        public string Currency { get; set; }

        [Field("FRAMETYPE")]
        [ParameterType(DbType.String)]
        public string Frametype { get; set; }

        [Field("FRAMESIZE")]
        [ParameterType(DbType.String)]
        public string Framesize { get; set; }

        [Field("SILLTYPE")]
        [ParameterType(DbType.String)]
        public string Silltype { get; set; }

        [Field("SILLSIZE")]
        [ParameterType(DbType.String)]
        public string Sillsize { get; set; }

        [Field("SILLHEIGHT")]
        [ParameterType(DbType.String)]
        public string Sillheight { get; set; }

        [Field("MODEL")]
        [ParameterType(DbType.String)]
        public string Model { get; set; }

        [Field("SASHSIZE")]
        [ParameterType(DbType.String)]
        public string Sashsize { get; set; }

        [Field("COLOR")]
        [ParameterType(DbType.String)]
        public string Color { get; set; }

        [Field("FILLING")]
        [ParameterType(DbType.String)]
        public string Filling { get; set; }

        [Field("LOCK")]
        [ParameterType(DbType.String)]
        public string Lock { get; set; }

        [Field("PROP1")]
        [ParameterType(DbType.String)]
        public string Prop1 { get; set; }

        [Field("PROP2")]
        [ParameterType(DbType.String)]
        public string Prop2 { get; set; }

        [Field("PROP3")]
        [ParameterType(DbType.String)]
        public string Prop3 { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
