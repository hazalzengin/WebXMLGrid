using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_OFFERCREDIT için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_OFFERCREDIT")]
    public class AdmOffercredit : BaseModel
    {

        #region Constructor

        public AdmOffercredit()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmOffercredit_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Date_ { get; set; }

        [Field("DUEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Duedate { get; set; }

        [Field("CLCARDREF")]
        [ParameterType(DbType.Int32)]
        public int? Clcardref { get; set; }

        [Field("CLCARDCODE")]
        [ParameterType(DbType.String)]
        public string Clcardcode { get; set; }

        [Field("CLCARDDEF")]
        [ParameterType(DbType.String)]
        public string Clcarddef { get; set; }

        [Field("SALESMANREF")]
        [ParameterType(DbType.Int32)]
        public int? Salesmanref { get; set; }

        [Field("SALESMANDEF")]
        [ParameterType(DbType.String)]
        public string Salesmandef { get; set; }

        [Field("PRICELISTCODE")]
        [ParameterType(DbType.String)]
        public string Pricelistcode { get; set; }

        [Field("EXP")]
        [ParameterType(DbType.String)]
        public string Exp { get; set; }

        [Field("ISACIKHESAP")]
        [ParameterType(DbType.Int32)]
        public int? Isacikhesap { get; set; }

        [Field("VADEDATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Vadedate_ { get; set; }

        [Field("AMOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Amount { get; set; }

        [Field("ISKONTO_BEYAZ")]
        [ParameterType(DbType.Double)]
        public double? IskontoBeyaz { get; set; }

        [Field("ISKONTO_BEJ")]
        [ParameterType(DbType.Double)]
        public double? IskontoBej { get; set; }

        [Field("ISKONTO_LAMINE")]
        [ParameterType(DbType.Double)]
        public double? IskontoLamine { get; set; }

        [Field("ISKONTO_AKSESUAR")]
        [ParameterType(DbType.Double)]
        public double? IskontoAksesuar { get; set; }

        [Field("STATUS")]
        [ParameterType(DbType.Int32)]
        public int? Status { get; set; }

        [Field("APPROVESTATUS")]
        [ParameterType(DbType.Int32)]
        public int? Approvestatus { get; set; }

        [Field("APPROVEDBY")]
        [ParameterType(DbType.String)]
        public string Approvedby { get; set; }

        [Field("APPROVEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Approvedate { get; set; }

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
