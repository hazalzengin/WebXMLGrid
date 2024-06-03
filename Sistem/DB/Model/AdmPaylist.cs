using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_PAYLIST için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_PAYLIST")]
    public class AdmPaylist : BaseModel
    {

        #region Constructor

        public AdmPaylist()
        {

        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmPaylist_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("SOURCETYPE")]
        [ParameterType(DbType.Int32)]
        public int? Sourcetype { get; set; }

        [Field("SOURCENO")]
        [ParameterType(DbType.String)]
        public string Sourceno { get; set; }

        [Field("CLCODE")]
        [ParameterType(DbType.String)]
        public string Clcode { get; set; }

        [Field("CLNAME")]
        [ParameterType(DbType.String)]
        public string Clname { get; set; }

        [Field("SOURCETOTAL")]
        [ParameterType(DbType.Decimal)]
        public decimal? Sourcetotal { get; set; }

        [Field("SOURCEEXP")]
        [ParameterType(DbType.String)]
        public string Sourceexp { get; set; }

        [Field("SOURCEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Sourcedate { get; set; }

        [Field("SOURCEDUEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Sourceduedate { get; set; }

        [Field("DATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Date { get; set; }

        [Field("TOTAL")]
        [ParameterType(DbType.Decimal)]
        public decimal? Total { get; set; }

        [Field("CURRENCY")]
        [ParameterType(DbType.Int32)]
        public int? Currency { get; set; }

        [Field("EXP")]
        [ParameterType(DbType.String)]
        public string Exp { get; set; }

        [Field("STATUS")]
        [ParameterType(DbType.Int32)]
        public int? Status { get; set; }

        #endregion

    }
}
