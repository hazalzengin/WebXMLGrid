using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_EXCELL_TEMPLATE için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_EXCELL_TEMPLATE")]
    public class AdmExcellTemplate : BaseModel
    {

        #region Constructor

        public AdmExcellTemplate()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmExcellTemplate_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("PAGENAME")]
        [ParameterType(DbType.String)]
        public string Pagename { get; set; }

        [Field("FIELDNAME")]
        [ParameterType(DbType.String)]
        public string Fieldname { get; set; }

        [Field("EXP_")]
        [ParameterType(DbType.String)]
        public string Exp_ { get; set; }

        [Field("ORDERNO")]
        [ParameterType(DbType.Int32)]
        public int? Orderno { get; set; }

        [Field("DATATYPE")]
        [ParameterType(DbType.String)]
        public string Datatype { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
