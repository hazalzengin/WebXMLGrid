using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_WORKGROUP i�in base class�
    /// </summary>
    [Serializable]
    [TableName("ADM_WORKGROUP")]
    public class AdmWorkgroup : BaseModel
    {

        #region Constructor

        public AdmWorkgroup()
        {
        
        }

        #endregion

        #region Tablonun columnlar�

        [PK]
        [Identity("AdmWorkgroup_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("CODE")]
        [ParameterType(DbType.String)]
        public string Code { get; set; }

        [Field("DEFINITION_")]
        [ParameterType(DbType.String)]
        public string Definition_ { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
