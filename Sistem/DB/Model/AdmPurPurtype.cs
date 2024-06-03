using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_PUR_PURTYPE için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_PUR_PURTYPE")]
    public class AdmPurPurtype
    {

        #region Constructor

        public AdmPurPurtype()
        {
        
        }

        #endregion

        #region Tablonun columnlarý
        [PK]
        [Identity("AdmPurPurtype_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("DOCTYPE")]
        [ParameterType(DbType.String)]
        public string Doctype { get; set; }

        [Field("DOCNAME")]
        [ParameterType(DbType.String)]
        public string Docname { get; set; }

        [Field("PURTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Purtype { get; set; }

        [Field("CONTROLVENDOR")]
        [ParameterType(DbType.Int32)]
        public int? Controlvendor { get; set; }

        [Field("DESIGNID")]
        [ParameterType(DbType.Int32)]
        public int? Designid { get; set; }

        [Field("EXP")]
        [ParameterType(DbType.String)]
        public string Exp { get; set; }

        [Field("ISSIGN")]
        [ParameterType(DbType.Int32)]
        public int? Issign { get; set; }

        [Field("SIGNTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Signtype { get; set; }

        [Field("LIMITC")]
        [ParameterType(DbType.Decimal)]
        public decimal? Limitc { get; set; }

        [Field("LIMITB")]
        [ParameterType(DbType.Decimal)]
        public decimal? Limitb { get; set; }

        [Field("CONTROLLIMIT")]
        [ParameterType(DbType.Int32)]
        public int? Controllimit { get; set; }

        [Field("AUSERS")]
        [ParameterType(DbType.String)]
        public string Ausers { get; set; }

        [Field("BUSERS")]
        [ParameterType(DbType.String)]
        public string Busers { get; set; }

        [Field("CUSERS")]
        [ParameterType(DbType.String)]
        public string Cusers { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
