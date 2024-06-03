using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_QLT_PARAM için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_QLT_PARAM")]
    public class AdmQltParam : BaseModel
    {

        #region Constructor

        public AdmQltParam()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmQltParam_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("CODE")]
        [ParameterType(DbType.String)]
        public string Code { get; set; }

        [Field("NAME")]
        [ParameterType(DbType.String)]
        public string Name { get; set; }

        [Field("VALIDFROM")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Validfrom { get; set; }

        [Field("VALIDUNTIL")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Validuntil { get; set; }

        [Field("ISPUR")]
        [ParameterType(DbType.Int32)]
        public int? Ispur { get; set; }

        [Field("ISPROD")]
        [ParameterType(DbType.Int32)]
        public int? Isprod { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
