using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_PUR_AUTHGROUPUSER için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_PUR_AUTHGROUPUSER")]
    public class AdmPurAuthgroupuser : BaseModel
    {

        #region Constructor

        public AdmPurAuthgroupuser()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmPurAuthgroupuser_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("GROUPREF")]
        [ParameterType(DbType.Int32)]
        public int Groupref { get; set; }

        [Field("USERREF")]
        [ParameterType(DbType.Int32)]
        public int Userref { get; set; }

        [Field("SHOWALL")]
        [ParameterType(DbType.Int32)]
        public int? Showall { get; set; }

        [Field("ISADMIN")]
        [ParameterType(DbType.Int32)]
        public int? Isadmin { get; set; }

        [Field("ISDEPPERSONNEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdeppersonnel { get; set; }

        [Field("SENDMAILFORAPPROVE")]
        [ParameterType(DbType.Int32)]
        public int? Sendmailforapprove { get; set; }

        [Field("SHOWONLYACCEPTED")]
        [ParameterType(DbType.Int32)]
        public int? Showonlyaccepted { get; set; }

        [Field("CONDITION")]
        [ParameterType(DbType.String)]
        public string Condition { get; set; }

        #endregion

    }
}
