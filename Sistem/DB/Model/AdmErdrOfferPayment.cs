using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_ERDR_OFFER_PAYMENT için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_ERDR_OFFER_PAYMENT")]
    public class AdmErdrOfferPayment : BaseModel
    {

        #region Constructor

        public AdmErdrOfferPayment()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmErdrOfferPayment_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("OFFERREF")]
        [ParameterType(DbType.Int32)]
        public int? Offerref { get; set; }

        [Field("PAYMENTTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Paymenttype { get; set; }

        [Field("PAYMENTDATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Paymentdate_ { get; set; }

        [Field("AMOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Amount { get; set; }

        [Field("CURRENCYTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Currencytype { get; set; }

        [Field("CURRENCYRATE")]
        [ParameterType(DbType.Decimal)]
        public decimal? Currencyrate { get; set; }

        [Field("EXP1")]
        [ParameterType(DbType.String)]
        public string Exp1 { get; set; }

        [Field("PAYMENTSTATUS")]
        [ParameterType(DbType.Int32)]
        public int? Paymentstatus { get; set; }

        [Field("UPDATEDBY")]
        [ParameterType(DbType.String)]
        public string Updatedby { get; set; }

        [Field("UPDATEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Updatedate { get; set; }


        #endregion

    }
}
