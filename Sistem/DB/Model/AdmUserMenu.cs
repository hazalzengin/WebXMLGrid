using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_USER_MENU için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_USER_MENU")]
    public class AdmUserMenu : BaseModel
    {

        #region Constructor

        public AdmUserMenu()
        {
        
        }

        public AdmUserMenu( int userref,  int menuref)
        {
            this.Userref = userref;
            this.Menuref = menuref;

        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmUserMenu_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("USERREF")]
        [ParameterType(DbType.Int32)]
        public int Userref { get; set; }

        [Field("MENUREF")]
        [ParameterType(DbType.Int32)]
        public int Menuref { get; set; }

        #endregion

    }
}
