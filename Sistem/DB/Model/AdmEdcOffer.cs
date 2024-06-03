using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_EDC_OFFER için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_EDC_OFFER")]
    public class AdmEdcOffer : BaseModel
    {

        #region Constructor

        public AdmEdcOffer()
        {

        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmEdcOffer_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Date_ { get; set; }

        [Field("DUEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? DueDate { get; set; }

        [Field("DATE_OPSIYON")]
        [ParameterType(DbType.DateTime)]
        public DateTime? DateOpsiyon { get; set; }

        [Field("CREDITREF")]
        [ParameterType(DbType.Int32)]
        public int? Creditref { get; set; }

        [Field("LG_CLCARDREF")]
        [ParameterType(DbType.Int32)]
        public int? LgClcardref { get; set; }

        [Field("LG_CLCARDCODE")]
        [ParameterType(DbType.String)]
        public string LgClcardcode { get; set; }

        [Field("LG_CLCARDDEF")]
        [ParameterType(DbType.String)]
        public string LgClcarddef { get; set; }

        [Field("ADDRESS")]
        [ParameterType(DbType.String)]
        public string Address { get; set; }

        [Field("SALESMANREF")]
        [ParameterType(DbType.String)]
        public string Salesmanref { get; set; }

        [Field("SALESMANDEF")]
        [ParameterType(DbType.String)]
        public string Salesmandef { get; set; }

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

        [Field("DELIVERYTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Deliverytype { get; set; }

        [Field("DELIVERYTERM")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Deliveryterm { get; set; }

        [Field("SUBTOTAL")]
        [ParameterType(DbType.Decimal)]
        public decimal? Subtotal { get; set; }

        [Field("GROSSTOTAL")]
        [ParameterType(DbType.Decimal)]
        public decimal? Grosstotal { get; set; }

        [Field("DISCOUNT1")]
        [ParameterType(DbType.Decimal)]
        public decimal? Discount1 { get; set; }

        [Field("DISCOUNT2")]
        [ParameterType(DbType.Decimal)]
        public decimal? Discount2 { get; set; }

        [Field("DISCOUNT3")]
        [ParameterType(DbType.Decimal)]
        public decimal? Discount3 { get; set; }

        [Field("CONTACTNAME")]
        [ParameterType(DbType.String)]
        public string Contactname { get; set; }

        [Field("CONTACTMAIL")]
        [ParameterType(DbType.String)]
        public string Contactmail { get; set; }

        [Field("EXP1")]
        [ParameterType(DbType.String)]
        public string Exp1 { get; set; }

        [Field("EXP2")]
        [ParameterType(DbType.String)]
        public string Exp2 { get; set; }

        [Field("EXP3")]
        [ParameterType(DbType.String)]
        public string Exp3 { get; set; }

        [Field("EXP4")]
        [ParameterType(DbType.String)]
        public string Exp4 { get; set; }

        [Field("EXP5")]
        [ParameterType(DbType.String)]
        public string Exp5 { get; set; }

        [Field("CREATEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Createdate { get; set; }

        [Field("CREATEDBY")]
        [ParameterType(DbType.String)]
        public string Createdby { get; set; }

        [Field("UPDATEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Updatedate { get; set; }

        [Field("UPDATEDBY")]
        [ParameterType(DbType.String)]
        public string Updatedby { get; set; }

        [Field("DELETEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Deletedate { get; set; }

        [Field("DELETEDBY")]
        [ParameterType(DbType.String)]
        public string Deletedby { get; set; }

        [Field("STATUS")]
        [ParameterType(DbType.Int32)]
        public int? Status { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        [Field("TRANSFERSTATUS")]
        [ParameterType(DbType.Int32)]
        public int? Transferstatus { get; set; }

        [Field("TRANSFERREF")]
        [ParameterType(DbType.Int32)]
        public int? Transferref { get; set; }

        [Field("APPROVEAUTHREF")]
        [ParameterType(DbType.Int32)]
        public int? ApproveAuthRef { get; set; }

        #endregion

    }
}
