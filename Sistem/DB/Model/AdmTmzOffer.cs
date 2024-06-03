using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_TMZ_OFFER için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_TMZ_OFFER")]
    public class AdmTmzOffer : BaseModel
    {

        #region Constructor

        public AdmTmzOffer()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmTmzOffer_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Date_ { get; set; }

        [Field("DUEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Duedate { get; set; }

        [Field("LG_CLCARDREF")]
        [ParameterType(DbType.Int32)]
        public int? LgClcardref { get; set; }

        [Field("LG_CLCARDCODE")]
        [ParameterType(DbType.String)]
        public string LgClcardcode { get; set; }

        [Field("LG_CLCARDDEF")]
        [ParameterType(DbType.String)]
        public string LgClcarddef { get; set; }

        [Field("CURRENCYTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Currencytype { get; set; }

        [Field("CURRENCYRATE")]
        [ParameterType(DbType.Decimal)]
        public decimal? Currencyrate { get; set; }

        [Field("PAYMENTPLAN")]
        [ParameterType(DbType.String)]
        public string Paymentplan { get; set; }

        [Field("CROSSORDERNO")]
        [ParameterType(DbType.String)]
        public string Crossorderno { get; set; }

        [Field("SHIPDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Shipdate { get; set; }

        [Field("DELIVERYTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Deliverytype { get; set; }

        [Field("DELIVERYADDRESS")]
        [ParameterType(DbType.String)]
        public string Deliveryaddress { get; set; }

        [Field("NOTES")]
        [ParameterType(DbType.String)]
        public string Notes { get; set; }

        [Field("EXP")]
        [ParameterType(DbType.String)]
        public string Exp { get; set; }

        [Field("EXP_IMPORTANT")]
        [ParameterType(DbType.String)]
        public string ExpImportant { get; set; }

        [Field("CURR_USD")]
        [ParameterType(DbType.Decimal)]
        public decimal? CurrUsd { get; set; }

        [Field("CURR_EUR")]
        [ParameterType(DbType.Decimal)]
        public decimal? CurrEur { get; set; }

        [Field("SALESMANREF")]
        [ParameterType(DbType.Int32)]
        public int? Salesmanref { get; set; }

        [Field("SALESMANCODE")]
        [ParameterType(DbType.String)]
        public string Salesmancode { get; set; }

        [Field("SALESMANNAME")]
        [ParameterType(DbType.String)]
        public string Salesmanname { get; set; }      
        
        [Field("SALESTYPE")]
        [ParameterType(DbType.Int32)]
        public int Salestype { get; set; }

        [Field("DESIGNERREF")]
        [ParameterType(DbType.Int32)]
        public int? Designerref { get; set; }

        [Field("DESIGNERCODE")]
        [ParameterType(DbType.String)]
        public string Designercode { get; set; }

        [Field("DESIGNERNAME")]
        [ParameterType(DbType.String)]
        public string Designername { get; set; }

        [Field("BRANCHNR")]
        [ParameterType(DbType.String)]
        public string Branchnr { get; set; }

        [Field("BRANCHNAME")]
        [ParameterType(DbType.String)]
        public string Branchname { get; set; }

        [Field("DIVISIONNR")]
        [ParameterType(DbType.String)]
        public string Divisionnr { get; set; }

        [Field("DIVISIONNAME")]
        [ParameterType(DbType.String)]
        public string Divisionname { get; set; }

        [Field("FACTORYNR")]
        [ParameterType(DbType.String)]
        public string Factorynr { get; set; }

        [Field("FACTORYNAME")]
        [ParameterType(DbType.String)]
        public string Factoryname { get; set; }

        [Field("WAREHOUSENR")]
        [ParameterType(DbType.String)]
        public string Warehousenr { get; set; }

        [Field("WAREHOUSENAME")]
        [ParameterType(DbType.String)]
        public string Warehousename { get; set; }

        [Field("PROJECTCODE")]
        [ParameterType(DbType.String)]
        public string Projectcode { get; set; }

        [Field("PROJECTNAME")]
        [ParameterType(DbType.String)]
        public string Projectname { get; set; }

        [Field("SPECODE")]
        [ParameterType(DbType.String)]
        public string Specode { get; set; }

        [Field("STATUS")]
        [ParameterType(DbType.Int32)]
        public int? Status { get; set; }

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

        [Field("TRANSFER_STATUS")]
        [ParameterType(DbType.Int32)]
        public int? TransferStatus { get; set; }

        [Field("TRANSFER_LGREF")]
        [ParameterType(DbType.Int32)]
        public int? TransferLgref { get; set; }

        [Field("TRANSFER_MESSAGE")]
        [ParameterType(DbType.String)]
        public string TransferMessage { get; set; }

        [Field("ISSYSTEMOFFER")]
        [ParameterType(DbType.Int32)]
        public int? Issystemoffer { get; set; }

        #endregion

    }
}
