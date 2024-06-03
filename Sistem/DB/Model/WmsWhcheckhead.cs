using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// WMS_WHCHECKHEAD için base classý
    /// </summary>
    [Serializable]
    [TableName("WMS_WHCHECKHEAD")]
    public class WmsWhcheckhead : BaseModel
    {

        #region Constructor

        public WmsWhcheckhead()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("WmsWhcheckhead_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Date_ { get; set; }

        [Field("BRANCH")]
        [ParameterType(DbType.Int32)]
        public int? Branch { get; set; }

        [Field("SOURCEINDEX")]
        [ParameterType(DbType.Int32)]
        public int? Sourceindex { get; set; }

        [Field("ISCOMPLETED")]
        [ParameterType(DbType.Int32)]
        public int? Iscompleted { get; set; }

        [Field("MOVEFICHEREF")]
        [ParameterType(DbType.Int32)]
        public int? Moveficheref { get; set; }

        [Field("ISCOUNTFICHE")]
        [ParameterType(DbType.Int32)]
        public int? Iscountfiche { get; set; }

        [Field("ISOPENFICHE")]
        [ParameterType(DbType.Int32)]
        public int? Isopenfiche { get; set; }

        [Field("WILLTRANSFER")]
        [ParameterType(DbType.Int32)]
        public int? Willtransfer { get; set; }

        [Field("CREATEDAT")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Createdat { get; set; }

        [Field("CREATEDBY")]
        [ParameterType(DbType.String)]
        public String Createdby { get; set; }

        [Field("CHANGEDAT")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Changedat { get; set; }

        [Field("CHANGEDBY")]
        [ParameterType(DbType.String)]
        public String Changedby { get; set; }

        #endregion

    }
}
