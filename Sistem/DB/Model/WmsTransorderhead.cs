using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// WMS_TRANSORDERHEAD için base classý
    /// </summary>
    [Serializable]
    [TableName("WMS_TRANSORDERHEAD")]
    public class WmsTransorderhead : BaseModel
    {

        #region Constructor

        public WmsTransorderhead()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("WmsTransorderhead_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Date_ { get; set; }

        [Field("FICHENO")]
        [ParameterType(DbType.String)]
        public string Ficheno { get; set; }

        [Field("BRANCH")]
        [ParameterType(DbType.Int32)]
        public int? Branch { get; set; }

        [Field("SOURCEINDEX")]
        [ParameterType(DbType.Int32)]
        public int? Sourceindex { get; set; }

        [Field("SOURCELOCATION")]
        [ParameterType(DbType.Int32)]
        public int? Sourcelocation { get; set; }

        [Field("DESTINDEX")]
        [ParameterType(DbType.Int32)]
        public int? Destindex { get; set; }

        [Field("DESTLOCATION")]
        [ParameterType(DbType.Int32)]
        public int? Destlocation { get; set; }

        [Field("ISDELETE")]
        [ParameterType(DbType.Int32)]
        public int? Isdelete { get; set; }

        [Field("ISCOMPLETED")]
        [ParameterType(DbType.Int32)]
        public int? Iscompleted { get; set; }

        [Field("WMSMOVEFICHEREF")]
        [ParameterType(DbType.Int32)]
        public int? Wmsmoveficheref { get; set; }

        [Field("CREATEDAT")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Createdat { get; set; }

        [Field("CREATEDBY")]
        [ParameterType(DbType.Int32)]
        public int? Createdby { get; set; }

        [Field("CHANGEDAT")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Changedat { get; set; }

        [Field("CHANGEDBY")]
        [ParameterType(DbType.Int32)]
        public int? Changedby { get; set; }

        #endregion

    }
}
