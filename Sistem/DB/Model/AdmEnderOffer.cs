using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_ENDER_OFFER için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_ENDER_OFFER")]
    public class AdmEnderOffer : BaseModel
    {

        #region Constructor

        public AdmEnderOffer()
        {

        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmEnderOffer_seq")]
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

        [Field("CREDITREF")]
        [ParameterType(DbType.Int32)]
        public int? Creditref { get; set; }

        [Field("CURRENCYTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Currencytype { get; set; }

        [Field("CURRENCYRATE")]
        [ParameterType(DbType.Decimal)]
        public decimal? Currencyrate { get; set; }

        [Field("DELIVERYTERM")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Deliveryterm { get; set; }

        [Field("DELIVERYADDRESSCODE")]
        [ParameterType(DbType.String)]
        public string Deliveryaddresscode { get; set; }

        [Field("DELIVERYADDRESS")]
        [ParameterType(DbType.String)]
        public string Deliveryaddress { get; set; }

        [Field("SUBTOTALX")]
        [ParameterType(DbType.Decimal)]
        public decimal? Subtotalx { get; set; }

        [Field("GROSSTOTALX")]
        [ParameterType(DbType.Decimal)]
        public decimal? Grosstotalx { get; set; }

        [Field("DISCOUNT1")]
        [ParameterType(DbType.Decimal)]
        public decimal? Discount1 { get; set; }

        [Field("DISCOUNT2")]
        [ParameterType(DbType.Decimal)]
        public decimal? Discount2 { get; set; }

        [Field("DISCOUNT3")]
        [ParameterType(DbType.Decimal)]
        public decimal? Discount3 { get; set; }

        [Field("CUST_EXP")]
        [ParameterType(DbType.String)]
        public string CustExp { get; set; }

        [Field("EXP")]
        [ParameterType(DbType.String)]
        public string Exp { get; set; }

        [Field("CURR_USD")]
        [ParameterType(DbType.Decimal)]
        public decimal? CurrUsd { get; set; }

        [Field("CURR_EUR")]
        [ParameterType(DbType.Decimal)]
        public decimal? CurrEur { get; set; }

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

        [Field("STATUS")]
        [ParameterType(DbType.Int32)]
        public int? Status { get; set; }

        [Field("APPROVEDBY")]
        [ParameterType(DbType.String)]
        public string Approvedby { get; set; }

        [Field("APPROVEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Approvedate { get; set; }

        [Field("APPROVE_MESSAGE")]
        [ParameterType(DbType.String)]
        public string ApproveMessage { get; set; }

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

        [Field("TRANSFER_MESSAGE")]
        [ParameterType(DbType.String)]
        public string TransferMessage { get; set; }

        #endregion

    }
}
