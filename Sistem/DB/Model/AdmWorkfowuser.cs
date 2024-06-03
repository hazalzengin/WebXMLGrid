using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_WORKFOWUSER için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_WORKFOWUSER")]
    public class AdmWorkfowuser : BaseModel
    {

        #region Constructor

        public AdmWorkfowuser()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmWorkfowuser_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("USERCODE")]
        [ParameterType(DbType.String)]
        public string Usercode { get; set; }

        [Field("DESC")]
        [ParameterType(DbType.String)]
        public string Desc { get; set; }

        [Field("SENDMAIL")]
        [ParameterType(DbType.Int32)]
        public int? Sendmail { get; set; }

        [Field("SENDSMS")]
        [ParameterType(DbType.Int32)]
        public int? Sendsms { get; set; }

        [Field("ISCLIENT")]
        [ParameterType(DbType.Int32)]
        public int? Isclient { get; set; }

        [Field("RESTARTWFIFREJECT")]
        [ParameterType(DbType.Int32)]
        public int? Restartwfifreject { get; set; }

        [Field("STOPIFREJECT")]
        [ParameterType(DbType.Int32)]
        public int? Stopifreject { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
