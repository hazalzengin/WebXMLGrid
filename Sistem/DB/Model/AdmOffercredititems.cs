using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_OFFERCREDITITEMS için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_OFFERCREDITITEMS")]
    public class AdmOffercredititems : BaseModel
    {

        #region Constructor

        public AdmOffercredititems()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmOffercredititems_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("OFFERCREDITREF")]
        [ParameterType(DbType.Int32)]
        public int? Offercreditref { get; set; }

        [Field("PAYMENTTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Paymenttype { get; set; }

        [Field("PAYMENTDATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Paymentdate_ { get; set; }      
        
        [Field("VADEDATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Vadedate_ { get; set; }

        [Field("AMOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Amount { get; set; }

        [Field("LGMODULNR")]
        [ParameterType(DbType.Int32)]
        public int? Lgmodulnr { get; set; }

        [Field("LGMODULNAME")]
        [ParameterType(DbType.String)]
        public string Lgmodulname { get; set; }

        [Field("LGMODULEREF")]
        [ParameterType(DbType.Int32)]
        public int? Lgmoduleref { get; set; }

        [Field("LGTRANREF")]
        [ParameterType(DbType.Int32)]
        public int? Lgtranref { get; set; }

        [Field("LGTRANNO")]
        [ParameterType(DbType.String)]
        public string Lgtranno { get; set; }

        [Field("CURRENCYTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Currencytype { get; set; }

        [Field("CURRENCYRATE")]
        [ParameterType(DbType.Decimal)]
        public decimal? Currencyrate { get; set; }

        [Field("EXP1")]
        [ParameterType(DbType.String)]
        public string Exp1 { get; set; }

        #endregion

    }
}
