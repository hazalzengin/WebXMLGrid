using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_MODULE_CONF için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_MODULE_CONF")]
    public class AdmModuleConf : BaseModel
    {

        #region Constructor

        public AdmModuleConf()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmModuleConf_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("MODULECODE")]
        [ParameterType(DbType.String)]
        public string Modulecode { get; set; }

        [Field("MODULENAME")]
        [ParameterType(DbType.String)]
        public string Modulename { get; set; }

        [Field("PAGENAME")]
        [ParameterType(DbType.String)]
        public string Pagename { get; set; }

        [Field("LINK")]
        [ParameterType(DbType.String)]
        public string Link { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
