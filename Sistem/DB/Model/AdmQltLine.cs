using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_QLT_LINE için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_QLT_LINE")]
    public class AdmQltLine : BaseModel
    {

        #region Constructor

        public AdmQltLine()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmQltLine_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("HEADREF")]
        [ParameterType(DbType.Int32)]
        public int? Headref { get; set; }

        [Field("PARAMREF")]
        [ParameterType(DbType.Int32)]
        public int? Paramref { get; set; }

        [Field("PARAMCODE")]
        [ParameterType(DbType.String)]
        public string Paramcode { get; set; }

        [Field("PARAMNAME")]
        [ParameterType(DbType.String)]
        public string Paramname { get; set; }

        [Field("PARAMVALREF")]
        [ParameterType(DbType.Int32)]
        public int? Paramvalref { get; set; }

        [Field("PARAMVALCODE")]
        [ParameterType(DbType.String)]
        public string Paramvalcode { get; set; }

        [Field("PARAMVALNAME")]
        [ParameterType(DbType.String)]
        public string Paramvalname { get; set; }

        [Field("PARAMVALUE")]
        [ParameterType(DbType.String)]
        public string Paramvalue { get; set; }

        [Field("ISAPPROVED")]
        [ParameterType(DbType.Int32)]
        public int? Isapproved { get; set; }

        #endregion

    }
}
