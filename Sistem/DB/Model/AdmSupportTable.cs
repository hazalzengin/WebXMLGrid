using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_SUPPORT_TABLE için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_SUPPORT_TABLE")]
    public class AdmSupportTable
    {

        #region Constructor

        public AdmSupportTable()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmSupportTable_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("MENUPARENTREF")]
        [ParameterType(DbType.Int32)]
        public int? Menuparentref { get; set; }

        [Field("MODULNAME")]
        [ParameterType(DbType.String)]
        public string Modulname { get; set; }

        [Field("PAGE")]
        [ParameterType(DbType.String)]
        public string Page { get; set; }

        [Field("EXP")]
        [ParameterType(DbType.String)]
        public string Exp { get; set; }

        [Field("CREATEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Createdate { get; set; }

        [Field("CREATEDBY")]
        [ParameterType(DbType.String)]
        public string Createdby { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
