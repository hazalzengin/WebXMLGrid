using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_CASHFLOW_DELAY için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_CASHFLOW_DELAY")]
    public class AdmCashflowDelay : BaseModel
    {

        #region Constructor

        public AdmCashflowDelay()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmCashflowDelay_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("MODUL")]
        [ParameterType(DbType.Int32)]
        public int? Modul { get; set; }

        [Field("PARENTREF")]
        [ParameterType(DbType.Int32)]
        public int? Parentref { get; set; }

        [Field("FICHETYPE")]
        [ParameterType(DbType.String)]
        public string Fichetype { get; set; }

        [Field("FICHEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Fichedate { get; set; }

        [Field("DETAIL")]
        [ParameterType(DbType.String)]
        public string Detail { get; set; }

        [Field("AMOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Amount { get; set; }

        [Field("CURRENCYTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Currencytype { get; set; }

        [Field("CURRENCYRATE")]
        [ParameterType(DbType.Decimal)]
        public decimal? Currencyrate { get; set; }

        [Field("DELAYDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Delaydate { get; set; }

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

        #endregion

    }
}
