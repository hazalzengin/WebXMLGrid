using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_DBSBANKLIMIT için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_DBSBANKLIMIT")]
    public class AdmDbsbanklimit : BaseModel
    {

        #region Constructor

        public AdmDbsbanklimit()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmDbsbanklimit_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("USERNAME")]
        [ParameterType(DbType.String)]
        public string Username { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Date_ { get; set; }

        [Field("DBSCLREF")]
        [ParameterType(DbType.Int32)]
        public int? Dbsclref { get; set; }

        [Field("DBSCLCODE")]
        [ParameterType(DbType.String)]
        public string Dbsclcode { get; set; }

        [Field("DBSCLDEFINITION")]
        [ParameterType(DbType.String)]
        public string Dbscldefinition { get; set; }

        [Field("DBSBNREF")]
        [ParameterType(DbType.String)]
        public string Dbsbnref { get; set; }

        [Field("DBSBNCODE")]
        [ParameterType(DbType.String)]
        public string Dbsbncode { get; set; }

        [Field("DBSBNDEFINITION")]
        [ParameterType(DbType.String)]
        public string Dbsbndefinition { get; set; }

        [Field("DBSLIMIT")]
        [ParameterType(DbType.Double)]
        public double? Dbslimit { get; set; }

        [Field("DBSCURRENCY")]
        [ParameterType(DbType.String)]
        public string Dbscurrency { get; set; }

        [Field("DBSACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Dbsactive { get; set; }

        [Field("SIGN")]
        [ParameterType(DbType.Int32)]
        public int? Sign { get; set; }

        [Field("BNKCRDLIMIT")]
        [ParameterType(DbType.Double)]
        public double? Bnkcrdlimit { get; set; }

        #endregion

    }
}
