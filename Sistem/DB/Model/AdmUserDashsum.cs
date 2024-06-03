using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_USER_DASHSUM için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_USER_DASHSUM")]
    public class AdmUserDashsum : BaseModel
    {

        #region Constructor

        public AdmUserDashsum()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmUserDashsum_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("USERREF")]
        [ParameterType(DbType.Int32)]
        public int? Userref { get; set; }

        [Field("DASHSUMREF")]
        [ParameterType(DbType.Int32)]
        public int? Dashsumref { get; set; }

        #endregion

    }
}
