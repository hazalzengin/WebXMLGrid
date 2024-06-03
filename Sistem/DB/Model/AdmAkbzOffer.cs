using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_AKBZ_OFFER için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_AKBZ_OFFER")]
    public class AdmAkbzOffer : BaseModel
    {

        #region Constructor

        public AdmAkbzOffer()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmAkbzOffer_seq")]
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

        [Field("CURRENCYTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Currencytype { get; set; }

        [Field("CURRENCYRATE")]
        [ParameterType(DbType.Decimal)]
        public decimal? Currencyrate { get; set; }

        [Field("PAYMENTTYPE")]
        [ParameterType(DbType.String)]
        public string Paymenttype { get; set; }

        [Field("PAYMENTDUEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Paymentduedate { get; set; }

        [Field("DELIVERYTERM")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Deliveryterm { get; set; }

        [Field("DISCOUNT1")]
        [ParameterType(DbType.Decimal)]
        public decimal? Discount1 { get; set; }

        [Field("DISCOUNT2")]
        [ParameterType(DbType.Decimal)]
        public decimal? Discount2 { get; set; }

        [Field("DISCOUNT3")]
        [ParameterType(DbType.Decimal)]
        public decimal? Discount3 { get; set; }

        [Field("FACTORYREF")]
        [ParameterType(DbType.Int32)]
        public int? Factoryref { get; set; }

        [Field("FACTORYDEF")]
        [ParameterType(DbType.String)]
        public string Factorydef { get; set; }

        [Field("WHREF")]
        [ParameterType(DbType.Int32)]
        public int? Whref { get; set; }

        [Field("WHDEF")]
        [ParameterType(DbType.String)]
        public string Whdef { get; set; }

        [Field("EXP1")]
        [ParameterType(DbType.String)]
        public string Exp1 { get; set; }

        [Field("EXP2")]
        [ParameterType(DbType.String)]
        public string Exp2 { get; set; }

        [Field("EXP3")]
        [ParameterType(DbType.String)]
        public string Exp3 { get; set; }

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
