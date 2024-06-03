using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_PRDPERSONNEL için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_PRDPERSONNEL")]
    public class AdmPrdpersonnel : BaseModel
    {

        #region Constructor

        public AdmPrdpersonnel()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmPrdpersonnel_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("CODE")]
        [ParameterType(DbType.String)]
        public string Code { get; set; }

        [Field("NAME")]
        [ParameterType(DbType.String)]
        public string Name { get; set; }

        [Field("PASSWORD")]
        [ParameterType(DbType.String)]
        public string Password { get; set; }

        [Field("WORKGROUP")]
        [ParameterType(DbType.String)]
        public string Workgroup { get; set; }

        [Field("WORKCENTER")]
        [ParameterType(DbType.String)]
        public string Workcenter { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
