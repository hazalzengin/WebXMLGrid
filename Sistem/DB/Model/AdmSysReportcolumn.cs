using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_SYS_REPORTCOLUMN için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_SYS_REPORTCOLUMN")]
    public class AdmSysReportcolumn : BaseModel
    {

        #region Constructor

        public AdmSysReportcolumn()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmSysReportcolumn_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("HEADREF")]
        [ParameterType(DbType.Int32)]
        public int? Headref { get; set; }

        [Field("COLUMNORDER")]
        [ParameterType(DbType.Int32)]
        public int? Columnorder { get; set; }

        [Field("FIELDNAME")]
        [ParameterType(DbType.String)]
        public string Fieldname { get; set; }

        [Field("FILEDTEXT")]
        [ParameterType(DbType.String)]
        public string Filedtext { get; set; }

        [Field("TYPE_")]
        [ParameterType(DbType.Int32)]
        public int? Type_ { get; set; }

        [Field("ISID")]
        [ParameterType(DbType.Int32)]
        public int? Isid { get; set; }

        [Field("HASSUBTOTAL")]
        [ParameterType(DbType.Int32)]
        public int? Hassubtotal { get; set; }

        [Field("SUBTOTALTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Subtotaltype { get; set; }

        [Field("SUBTOTALFORMAT")]
        [ParameterType(DbType.Int32)]
        public int Subtotalformat { get; set; }

        [Field("VISIBLE")]
        [ParameterType(DbType.Int32)]
        public int? Visible { get; set; }

        [Field("CANSORT")]
        [ParameterType(DbType.Int32)]
        public int? Cansort { get; set; }

        [Field("CANFILTER")]
        [ParameterType(DbType.Int32)]
        public int? Canfilter { get; set; }

        [Field("HASDETAILPOPUP")]
        [ParameterType(DbType.Int32)]
        public int? Hasdetailpopup { get; set; }

        #endregion

    }
}
