using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_LANGU için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_LANGU")]
    public class AdmLangu : BaseModel
    {

        #region Constructor

        public AdmLangu()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmLangu_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }


        [Field("REFID")]
        [ParameterType(DbType.Int32)]
        public int Refid { get; set; }

        [NoMapping]
        public string Tablen { get; set; }

        [Field("LANGU")]
        [ParameterType(DbType.String)]
        public string Langu { get; set; }

        [Field("STEXT")]
        [ParameterType(DbType.String)]
        public string Stext { get; set; }

        #endregion

    }
}
