using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_ZYHN_OFFER için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_ZYHN_OFFER")]
    public class AdmZyhnOffer : BaseModel
    {

        #region Constructor

        public AdmZyhnOffer()
        {

        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmZyhnOffer_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Date_ { get; set; }

        [Field("DUEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? DueDate { get; set; }

        [Field("COMPANYCODE")]
        [ParameterType(DbType.String)]
        public string Companycode { get; set; }

        [Field("COMPANYDEF")]
        [ParameterType(DbType.String)]
        public string Companydef { get; set; }

        [Field("OFFERTYPE")]
        [ParameterType(DbType.String)]
        public string Offertype { get; set; }

        [Field("OFFERLANG")]
        [ParameterType(DbType.String)]
        public string Offerlang { get; set; }

        [Field("BRAND")]
        [ParameterType(DbType.String)]
        public string Brand { get; set; }

        [Field("CLCARDTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Clcardtype { get; set; }

        [Field("ADM_CLCARDREF")]
        [ParameterType(DbType.Int32)]
        public int? AdmClcardref { get; set; }

        [Field("LG_CLCARDREF")]
        [ParameterType(DbType.Int32)]
        public int? LgClcardref { get; set; }

        [Field("CLCARDDEF")]
        [ParameterType(DbType.String)]
        public string Clcarddef { get; set; }

        [Field("CLCARDEXPRESSION")]
        [ParameterType(DbType.String)]
        public string Clcardexpression{ get; set; }

        [Field("ISNEWCLCARD")]
        [ParameterType(DbType.Int32)]
        public int? Isnewclcard { get; set; }

        [Field("SALESMANREF")]
        [ParameterType(DbType.Int32)]
        public int? Salesmanref { get; set; }

        [Field("SALESMANCODE")]
        [ParameterType(DbType.String)]
        public string Salesmancode { get; set; }

        [Field("SALESMANDEF")]
        [ParameterType(DbType.String)]
        public string Salesmandef { get; set; }

        [Field("CLPROPERTIESREF")]
        [ParameterType(DbType.Int32)]
        public int? Clpropertiesref { get; set; }

        [Field("SPECODE")]
        [ParameterType(DbType.String)]
        public string Specode { get; set; }

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

        [Field("CLIENTAPPROVETYPE")]
        [ParameterType(DbType.Int32)]
        public int? Clientapprovetype { get; set; }

        [Field("CONTACTNAME")]
        [ParameterType(DbType.String)]
        public string Contactname { get; set; }

        [Field("CONTACTMAIL")]
        [ParameterType(DbType.String)]
        public string Contactmail { get; set; }

        [Field("CONTACTPHONE")]
        [ParameterType(DbType.String)]
        public string Contactphone { get; set; }

        [Field("STATUS")]
        [ParameterType(DbType.Int32)]
        public int? Status { get; set; }

        [Field("TRANSFERSTATUS")]
        [ParameterType(DbType.Int32)]
        public int? Transferstatus { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

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

        #endregion

    }
}
