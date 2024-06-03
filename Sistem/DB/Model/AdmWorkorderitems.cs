using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_WORKORDERITEMS için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_WORKORDERITEMS")]
    public class AdmWorkorderitems : BaseModel
    {

        #region Constructor

        public AdmWorkorderitems()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmWorkorderitems_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("WORKORDERREF")]
        [ParameterType(DbType.Int32)]
        public int? Workorderref { get; set; }

        [Field("SUBITEMCODE")]
        [ParameterType(DbType.String)]
        public string Subitemcode { get; set; }

        [Field("SUBITEMNAME")]
        [ParameterType(DbType.String)]
        public string Subitemname { get; set; }

        [Field("PERAMOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Peramount { get; set; }

        [Field("CALCAMOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Calcamount { get; set; }

        [Field("SUBITEMUNIT")]
        [ParameterType(DbType.String)]
        public string Subitemunit { get; set; }

        [Field("SUBSCRAP")]
        [ParameterType(DbType.Decimal)]
        public decimal? Subscrap { get; set; }

        [Field("SUBSCRAPAMOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Subscrapamount { get; set; }

        [Field("CONSUMPTION")]
        [ParameterType(DbType.Decimal)]
        public decimal? Consumption { get; set; }

        [Field("EXP")]
        [ParameterType(DbType.String)]
        public string Exp { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
