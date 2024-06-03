using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_LOG için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_LOG")]
    public class AdmLog : BaseModel
    {

        #region Constructor

        public AdmLog()
        {

        }

        public AdmLog(DateTime logtime, string logsource, string logdetails)
        {
            this.Logtime = logtime;
            this.Logsource = logsource;
            this.Logdetails = logdetails;

        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmLog_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("LOGTIME")]
        [ParameterType(DbType.DateTime)]
        public DateTime Logtime { get; set; }

        [Field("LOGSOURCE")]
        [ParameterType(DbType.String)]
        public string Logsource { get; set; }

        [Field("LOGDETAILS")]
        [ParameterType(DbType.String)]
        public string Logdetails { get; set; }

        [Field("CREATEDBY")]
        [ParameterType(DbType.String)]
        public string Createdby { get; set; }

        #endregion

    }
}
