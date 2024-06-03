using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_BI_SABLON için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_BI_SABLON")]
    public class AdmBiSablon
    {

        #region Constructor

        public AdmBiSablon()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmBiSablon_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("CODE")]
        [ParameterType(DbType.String)]
        public string Code { get; set; }

        [Field("NAME")]
        [ParameterType(DbType.String)]
        public string Name { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("FIRMNO")]
        [ParameterType(DbType.String)]
        public string Firmno { get; set; }

        [Field("TYPE_")]
        [ParameterType(DbType.Int32)]
        public int? Type_ { get; set; }

        [Field("MASTERCODE")]
        [ParameterType(DbType.String)]
        public string Mastercode { get; set; }

        #endregion

    }
}
