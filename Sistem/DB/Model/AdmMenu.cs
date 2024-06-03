using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_MENU için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_MENU")]
    public class AdmMenu : BaseModel
    {

        #region Constructor

        public AdmMenu()
        {
        
        }

        public AdmMenu( int parentref,  string name,  string link,  string icon,  int orderno,  int authlevel,  int isvisible,  int isactive)
        {
            this.Parentref = parentref;
            this.Name = name;
            this.Link = link;
            this.Icon = icon;
            this.Orderno = orderno;
            this.Authlevel = authlevel;
            this.Isvisible = isvisible;
            this.Isactive = isactive;

        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmMenu_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("PARENTREF")]
        [ParameterType(DbType.Int32)]
        public int Parentref { get; set; }

        [Field("NAME")]
        [ParameterType(DbType.String)]
        public string Name { get; set; }

        [Field("LINK")]
        [ParameterType(DbType.String)]
        public string Link { get; set; }

        [Field("ICON")]
        [ParameterType(DbType.String)]
        public string Icon { get; set; }

        [Field("ORDERNO")]
        [ParameterType(DbType.Int32)]
        public int Orderno { get; set; }

        [Field("AUTHLEVEL")]
        [ParameterType(DbType.Int32)]
        public int Authlevel { get; set; }

        [Field("ISVISIBLE")]
        [ParameterType(DbType.Int32)]
        public int Isvisible { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int Isactive { get; set; }

        #endregion

    }
}
