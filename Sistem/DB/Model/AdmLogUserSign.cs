using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_LOG_USER_SIGN için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_LOG_USER_SIGN")]
    public class AdmLogUserSign : BaseModel
    {

        #region Constructor

        public AdmLogUserSign()
        {
        
        }
         
        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmLogUserSign_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime Date_ { get; set; }

        [Field("TIME_")]
        [ParameterType(DbType.String)]
        public string Time_ { get; set; }

        [Field("USERREF")]
        [ParameterType(DbType.Int32)]
        public int Userref { get; set; }

        [Field("DETAILS")]
        [ParameterType(DbType.String)]
        public string Details { get; set; }

        [Field("IP")]
        [ParameterType(DbType.String)]
        public string Ip { get; set; }

        [Field("BROWSER")]
        [ParameterType(DbType.String)]
        public string Browser { get; set; }

        #endregion

    }
}
