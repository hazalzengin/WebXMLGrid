using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_INFOBOX için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_INFOBOX")]
    public class AdmInfobox
    {

        #region Constructor

        public AdmInfobox()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmInfobox_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("PAGE_ID")]
        [ParameterType(DbType.Int32)]
        public int? PageId { get; set; }

        [Field("ROWNR")]
        [ParameterType(DbType.Int32)]
        public int? RowNr { get; set; }

        [Field("PAGE_NAME")]
        [ParameterType(DbType.String)]
        public string PageName { get; set; }

        [Field("PAGE_EXP")]
        [ParameterType(DbType.String)]
        public string PageExp { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
