using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_DBSCONNECTION için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_DBSCONNECTION")]
    public class AdmDbsconnection : BaseModel
    {

        #region Constructor

        public AdmDbsconnection()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmDbsconnection_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("CREATEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Createdate { get; set; }

        [Field("USERNAME")]
        [ParameterType(DbType.String)]
        public string Username { get; set; }

        [Field("CLREF")]
        [ParameterType(DbType.Int32)]
        public int? Clref { get; set; }

        [Field("DBSREF")]
        [ParameterType(DbType.Int32)]
        public int? Dbsref { get; set; }

        [Field("CONREF")]
        [ParameterType(DbType.Int32)]
        public int? Conref { get; set; }

        [Field("SIGN")]
        [ParameterType(DbType.Int32)]
        public int? Sign { get; set; }

        [Field("GENEEXP")]
        [ParameterType(DbType.String)]
        public string Geneexp { get; set; }

        [Field("AMOUNT")]
        [ParameterType(DbType.Double)]
        public double? Amount { get; set; }

        [Field("TRRATE")]
        [ParameterType(DbType.Double)]
        public double? Trrate { get; set; }

        [Field("TRNET")]
        [ParameterType(DbType.Double)]
        public double? Trnet { get; set; }

        [Field("PROCDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Procdate { get; set; }

        [Field("DUEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Duedate { get; set; }

        [Field("DTUR")]
        [ParameterType(DbType.String)]
        public string Dtur { get; set; }

        [Field("INVOICEREF")]
        [ParameterType(DbType.Int32)]
        public int? Invoiceref { get; set; }

        [Field("INVAMOUNT")]
        [ParameterType(DbType.Double)]
        public double? Invamount { get; set; }

        #endregion

    }
}
