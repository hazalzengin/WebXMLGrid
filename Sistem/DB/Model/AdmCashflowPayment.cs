using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_CASHFLOW_PAYMENT için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_CASHFLOW_PAYMENT")]
    public class AdmCashflowPayment : BaseModel
    {

        #region Constructor

        public AdmCashflowPayment()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmCashflowPayment_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("PTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Ptype { get; set; }

        [Field("PAYMENTTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Paymenttype { get; set; }

        [Field("PAYSELECTIONTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Payselectiontype { get; set; }

        [Field("PAYMENTDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Paymentdate { get; set; }

        [Field("AMOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Amount { get; set; }

        [Field("CURRENCYTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Currencytype { get; set; }

        [Field("CURRENCYRATE")]
        [ParameterType(DbType.Decimal)]
        public decimal? Currencyrate { get; set; }

        [Field("CLREF")]
        [ParameterType(DbType.Int32)]
        public int? Clref { get; set; }

        [Field("CLCODE")]
        [ParameterType(DbType.String)]
        public string Clcode { get; set; }

        [Field("CLNAME")]
        [ParameterType(DbType.String)]
        public string Clname { get; set; }

        [Field("BNREF")]
        [ParameterType(DbType.Int32)]
        public int? Bnref { get; set; }

        [Field("BNCODE")]
        [ParameterType(DbType.String)]
        public string Bncode { get; set; }

        [Field("BNNAME")]
        [ParameterType(DbType.String)]
        public string Bnname { get; set; }

        [Field("EXP1")]
        [ParameterType(DbType.String)]
        public string Exp1 { get; set; }

        [Field("CREATEDBY")]
        [ParameterType(DbType.String)]
        public string Createdby { get; set; }

        [Field("CREATEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Createdate { get; set; }

        [Field("UPDATEDBY")]
        [ParameterType(DbType.String)]
        public string Updatedby { get; set; }

        [Field("UPDATEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Updatedate { get; set; }

        [Field("DELETEDBY")]
        [ParameterType(DbType.String)]
        public string Deletedby { get; set; }

        [Field("DELETEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Deletedate { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
