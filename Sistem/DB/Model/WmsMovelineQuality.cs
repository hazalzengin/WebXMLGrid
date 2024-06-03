using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// WMS_MOVELINE_QUALITY için base classý
    /// </summary>
    [Serializable]
    [TableName("WMS_MOVELINE_QUALITY")]
    public class WmsMovelineQuality : BaseModel
    {

        #region Constructor

        public WmsMovelineQuality()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("WmsMovelineQuality_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("ORDERREF")]
        [ParameterType(DbType.Int32)]
        public int? Orderref { get; set; }

        [Field("OPRREF")]
        [ParameterType(DbType.Int32)]
        public int? Oprref { get; set; }

        [Field("BARCODE")]
        [ParameterType(DbType.String)]
        public string Barcode { get; set; }

        [Field("QUALITYSTATUS")]
        [ParameterType(DbType.Int32)]
        public int? Qualitystatus { get; set; }

        [Field("EXP")]
        [ParameterType(DbType.String)]
        public string Exp { get; set; }

        [Field("OTHER1")]
        [ParameterType(DbType.String)]
        public string Other1 { get; set; }

        [Field("OTHER2")]
        [ParameterType(DbType.String)]
        public string Other2 { get; set; }

        [Field("OTHER3")]
        [ParameterType(DbType.String)]
        public string Other3 { get; set; }

        [Field("CREATEDAT")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Createdat { get; set; }

        [Field("CREATEDBY")]
        [ParameterType(DbType.String)]
        public string Createdby { get; set; }

        [Field("CHANGEDAT")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Changedat { get; set; }

        [Field("CHANGEDBY")]
        [ParameterType(DbType.String)]
        public string Changedby { get; set; }

        #endregion

    }
}
