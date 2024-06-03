using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_WAITINGORDER_NOTES için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_WAITINGORDER_NOTES")]
    public class AdmWaitingorderNotes
    {

        #region Constructor

        public AdmWaitingorderNotes()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmWaitingorderNotes_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("ORDERL_REF")]
        [ParameterType(DbType.Int32)]
        public int? OrderlRef { get; set; }

        [Field("NOTES")]
        [ParameterType(DbType.String)]
        public string Notes { get; set; }

        [Field("CREATEDBY")]
        [ParameterType(DbType.String)]
        public string Createdby { get; set; }

        [Field("CREATEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Createdate { get; set; }

        #endregion

    }
}
