using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_DOCUMENT için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_DOCUMENT")]
    public class AdmDocument : BaseModel
    {

        #region Constructor

        public AdmDocument()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmDocument_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("FILENAME")]
        [ParameterType(DbType.String)]
        public string Filename { get; set; }

        [Field("EXP")]
        [ParameterType(DbType.String)]
        public string Exp { get; set; }

        [Field("DOCREF")]
        [ParameterType(DbType.Int32)]
        public int? Docref { get; set; }

        [Field("DOCNO")]
        [ParameterType(DbType.String)]
        public string Docno { get; set; }

        [Field("TITLE")]
        [ParameterType(DbType.String)]
        public string Title { get; set; }

        [Field("DOCEXT")]
        [ParameterType(DbType.String)]
        public string Docext { get; set; }

        [Field("MODUL")]
        [ParameterType(DbType.String)]
        public string Modul { get; set; }

        [Field("HASHTAG")]
        [ParameterType(DbType.String)]
        public string Hashtag { get; set; }

        [Field("CREATEDBY")]
        [ParameterType(DbType.String)]
        public string Createdby { get; set; }

        [Field("CREATEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Createdate { get; set; }

        [Field("DOC")]
        [ParameterType(DbType.Binary)]
        public byte[] Doc { get; set; }

        #endregion

    }
}
