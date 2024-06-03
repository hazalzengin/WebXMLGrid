using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_ITEMPROPERTIES için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_ITEMPROPERTIES")]
    public class AdmItemproperties : BaseModel
    {

        #region Constructor

        public AdmItemproperties()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmItemproperties_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("TYPE")]
        [ParameterType(DbType.String)]
        public string Type { get; set; }

        [Field("VALUE")]
        [ParameterType(DbType.String)]
        public string Value { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
