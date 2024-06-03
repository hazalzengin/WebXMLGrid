using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_BI_SABLONRESULT için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_BI_SABLONRESULT")]
    public class AdmBiSablonresult
    {

        #region Constructor

        public AdmBiSablonresult()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmBiSablonresult_seq")]
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

        [Field("VAL1")]
        [ParameterType(DbType.Decimal)]
        public decimal? Val1 { get; set; }

        [Field("VAL2")]
        [ParameterType(DbType.Decimal)]
        public decimal? Val2 { get; set; }

        [Field("VAL3")]
        [ParameterType(DbType.Decimal)]
        public decimal? Val3 { get; set; }

        [Field("VAL4")]
        [ParameterType(DbType.Decimal)]
        public decimal? Val4 { get; set; }

        #endregion

    }
}
