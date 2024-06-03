using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_USER_DASHBOARD i�in base class�
    /// </summary>
    [Serializable]
    [TableName("ADM_USER_DASHBOARD")]
    public class AdmUserDashboard : BaseModel
    {

        #region Constructor

        public AdmUserDashboard()
        {
        
        }

        #endregion

        #region Tablonun columnlar�

        [PK]
        [Identity("AdmUserDashboard_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("USERREF")]
        [ParameterType(DbType.Int32)]
        public int? Userref { get; set; }

        [Field("DASHBOARDREF")]
        [ParameterType(DbType.Int32)]
        public int? Dashboardref { get; set; }

        #endregion

    }
}
