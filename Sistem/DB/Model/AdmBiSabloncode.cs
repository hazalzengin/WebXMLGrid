using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_BI_SABLONCODE için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_BI_SABLONCODE")]
    public class AdmBiSabloncode
    {

        #region Constructor

        public AdmBiSabloncode()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmBiSabloncode_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("MASTERCODE")]
        [ParameterType(DbType.String)]
        public string Mastercode { get; set; }

        [Field("CODE")]
        [ParameterType(DbType.String)]
        public string Code { get; set; }

        [Field("NAME")]
        [ParameterType(DbType.String)]
        public string Name { get; set; }

        [Field("RUNPART")]
        [ParameterType(DbType.Int32)]
        public int? Runpart { get; set; }

        [Field("TOTTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Tottype { get; set; }

        [Field("ISFORMULA")]
        [ParameterType(DbType.Int32)]
        public int? Isformula { get; set; }

        [Field("ISBOLD")]
        [ParameterType(DbType.Int32)]
        public int? Isbold { get; set; }

        [Field("COLOR")]
        [ParameterType(DbType.String)]
        public string Color { get; set; }

        [Field("FIRMNO")]
        [ParameterType(DbType.String)]
        public string Firmno { get; set; }

        [Field("SIRA")]
        [ParameterType(DbType.Int32)]
        public int? Sira { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        #endregion

    }
}
