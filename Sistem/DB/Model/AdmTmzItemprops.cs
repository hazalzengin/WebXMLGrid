using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_TMZ_ITEMPROPS için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_TMZ_ITEMPROPS")]
    public class AdmTmzItemprops : BaseModel
    {

        #region Constructor

        public AdmTmzItemprops()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmTmzItemprops_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("STYPE")]
        [ParameterType(DbType.String)]
        public string Stype { get; set; }

        [Field("STEXT")]
        [ParameterType(DbType.String)]
        public string Stext { get; set; }

        [Field("VAL1")]
        [ParameterType(DbType.String)]
        public string Val1 { get; set; }

        [Field("VAL2")]
        [ParameterType(DbType.String)]
        public string Val2 { get; set; }

        [Field("VAL3")]
        [ParameterType(DbType.String)]
        public string Val3 { get; set; }

        [Field("VAL4")]
        [ParameterType(DbType.String)]
        public string Val4 { get; set; }

        [Field("VAL5")]
        [ParameterType(DbType.String)]
        public string Val5 { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
