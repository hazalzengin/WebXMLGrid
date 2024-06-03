using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_SYS_POPUPHEAD için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_SYS_POPUPHEAD")]
    public class AdmSysPopuphead : BaseModel
    {

        #region Constructor

        public AdmSysPopuphead()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmSysPopuphead_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("COLUMNREF")]
        [ParameterType(DbType.Int32)]
        public int? Columnref { get; set; }

        [Field("REPORTNAME")]
        [ParameterType(DbType.String)]
        public string Reportname { get; set; }

        [Field("SELECTC")]
        [ParameterType(DbType.String)]
        public string Selectc { get; set; }

        [Field("FROMC")]
        [ParameterType(DbType.String)]
        public string Fromc { get; set; }

        [Field("WHEREC")]
        [ParameterType(DbType.String)]
        public string Wherec { get; set; }

        [Field("GROUPC")]
        [ParameterType(DbType.String)]
        public string Groupc { get; set; }

        [Field("ORDERC")]
        [ParameterType(DbType.String)]
        public string Orderc { get; set; }

        [Field("HAVINGC")]
        [ParameterType(DbType.String)]
        public string Havingc { get; set; }

        [Field("HASDATEFILTER")]
        [ParameterType(DbType.Int32)]
        public int? Hasdatefilter { get; set; }

        [Field("DATEFIELD")]
        [ParameterType(DbType.String)]
        public string Datefield { get; set; }

        [Field("KEYFIELDNAME")]
        [ParameterType(DbType.String)]
        public string Keyfieldname { get; set; }

        [Field("CONNECTIONFIELD")]
        [ParameterType(DbType.String)]
        public string Connectionfield { get; set; }

        #endregion

    }
}
