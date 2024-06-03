using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_SYS_WEBREPORT için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_SYS_WEBREPORT")]
    public class AdmSysWebreport : BaseModel
    {

        #region Constructor

        public AdmSysWebreport()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmSysWebreport_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("REPORTCODE")]
        [ParameterType(DbType.String)]
        public string Reportcode { get; set; }

        [Field("REPORTNAME")]
        [ParameterType(DbType.String)]
        public string Reportname { get; set; }

        [Field("SELECTC")]
        [ParameterType(DbType.String)]
        public string Selectc { get; set; }

        [Field("FROMC")]
        [ParameterType(DbType.String)]
        public string Fromc { get; set; }

        [Field("WHEREC")]
        [ParameterType(DbType.String)]
        public string Wherec { get; set; }

        [Field("GROUPC")]
        [ParameterType(DbType.String)]
        public string Groupc { get; set; }

        [Field("ORDERC")]
        [ParameterType(DbType.String)]
        public string Orderc { get; set; }

        [Field("ARGUMAN")]
        [ParameterType(DbType.String)]
        public string Arguman { get; set; }

        [Field("DEGER")]
        [ParameterType(DbType.String)]
        public string Deger { get; set; }

        [Field("VIRGUL")]
        [ParameterType(DbType.Int32)]
        public int? Virgul { get; set; }

        [Field("TUR")]
        [ParameterType(DbType.Int32)]
        public int? Tur { get; set; }

        [Field("SIRA")]
        [ParameterType(DbType.Int32)]
        public int? Sira { get; set; }

        [Field("FIRMA")]
        [ParameterType(DbType.String)]
        public string Firma { get; set; }

        #endregion

    }
}
