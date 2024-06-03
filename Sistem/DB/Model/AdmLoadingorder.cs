using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_LOADINGORDER için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_LOADINGORDER")]
    public class AdmLoadingorder : BaseModel
    {

        #region Constructor

        public AdmLoadingorder()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmLoadingorder_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Date_ { get; set; }

        [Field("ISFIRMTRACK")]
        [ParameterType(DbType.Int32)]
        public int? Isfirmtrack { get; set; }

        [Field("TRACKNO")]
        [ParameterType(DbType.String)]
        public string Trackno { get; set; }

        [Field("DRIVERID")]
        [ParameterType(DbType.String)]
        public string Driverid { get; set; }

        [Field("DRIVERNAME")]
        [ParameterType(DbType.String)]
        public string Drivername { get; set; }

        [Field("EXP")]
        [ParameterType(DbType.String)]
        public string Exp { get; set; }

        [Field("STATUSREF")]
        [ParameterType(DbType.Int32)]
        public int? Statusref { get; set; }

        [Field("UPDATEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Updatedate { get; set; }

        [Field("UPDATEDBY")]
        [ParameterType(DbType.String)]
        public string Updatedby { get; set; }

        [Field("CREATEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Createdate { get; set; }

        [Field("CREATEDBY")]
        [ParameterType(DbType.String)]
        public string Createdby { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        [Field("TRANSFERMESSAGE")]
        [ParameterType(DbType.String)]
        public string TransferMessage { get; set; }

        #endregion

    }
}
