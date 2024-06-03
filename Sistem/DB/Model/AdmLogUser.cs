using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_LOG_USER için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_LOG_USER")]
    public class AdmLogUser : BaseModel
    {

        #region Constructor

        public AdmLogUser()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmLogUser_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime Date_ { get; set; }

        [Field("USERREF")]
        [ParameterType(DbType.Int32)]
        public int Userref { get; set; }

        [Field("QUERYTYPE")]
        [ParameterType(DbType.Int32)]
        public int Querytype { get; set; }

        [Field("RESULT")]
        [ParameterType(DbType.String)]
        public string Result{ get; set; }

        [Field("DETAIL")]
        [ParameterType(DbType.String)]
        public string Detail { get; set; }

        [Field("IP")]
        [ParameterType(DbType.String)]
        public string Ip { get; set; }

        [Field("BROWSER")]
        [ParameterType(DbType.String)]
        public string Browser { get; set; }

        #endregion

    }
}
