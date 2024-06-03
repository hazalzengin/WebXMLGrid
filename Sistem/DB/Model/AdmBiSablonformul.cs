using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_BI_SABLONFORMUL için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_BI_SABLONFORMUL")]
    public class AdmBiSablonformul
    {

        #region Constructor

        public AdmBiSablonformul()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmBiSablonformul_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("MASTERCODE")]
        [ParameterType(DbType.String)]
        public string Mastercode { get; set; }

        [Field("CODE")]
        [ParameterType(DbType.String)]
        public string Code { get; set; }

        [Field("VALUE")]
        [ParameterType(DbType.String)]
        public string Value { get; set; }

        [Field("ACCOUNT")]
        [ParameterType(DbType.String)]
        public string Account { get; set; }

        [Field("ISMULTIPLY")]
        [ParameterType(DbType.Int32)]
        public int? Ismultiply { get; set; }

        [Field("TOTTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Tottype { get; set; }

        [Field("MULTIPLYVAL")]
        [ParameterType(DbType.Double)]
        public double? Multiplyval { get; set; }

        [Field("WHEREADD")]
        [ParameterType(DbType.String)]
        public string Whereadd { get; set; }

        #endregion

    }
}
