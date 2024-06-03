using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_PRD_STOPCODE için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_PRD_STOPCODE")]
    public class AdmPrdStopcode : BaseModel
    {

        #region Constructor

        public AdmPrdStopcode()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmPrdStopcode_seq")]
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

        #endregion

    }
}
