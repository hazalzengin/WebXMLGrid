using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_DESIGN için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_DESIGN")]
    public class AdmDesign
    {

        #region Constructor

        public AdmDesign()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmDesign_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("CODE")]
        [ParameterType(DbType.String)]
        public string Code { get; set; }

        [Field("NAME")]
        [ParameterType(DbType.String)]
        public string Name { get; set; }

        [Field("MODULE")]
        [ParameterType(DbType.String)]
        public string Module { get; set; }

        [Field("PAGE")]
        [ParameterType(DbType.String)]
        public string Page { get; set; }

        [Field("CUSTOMER")]
        [ParameterType(DbType.String)]
        public string Customer { get; set; }

        [Field("LANGU")]
        [ParameterType(DbType.String)]
        public string Langu { get; set; }

        [Field("EXP")]
        [ParameterType(DbType.String)]
        public string Exp { get; set; }

        [Field("SQL")]
        [ParameterType(DbType.String)]
        public string Sql { get; set; }

        [Field("DETAILSQL")]
        [ParameterType(DbType.String)]
        public string Detailsql { get; set; }

        [Field("LAYOUTDATA")]
        [ParameterType(DbType.Binary)]
        public byte[] Layoutdata { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        [Field("CREATEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Createdate { get; set; }

        [Field("CREATEDBY")]
        [ParameterType(DbType.String)]
        public string Createdby { get; set; }

        [Field("FILTERCONDITION")]
        [ParameterType(DbType.String)]
        public string FilterCondition { get; set; }

        [Field("DETAILFILTERCONDITION")]
        [ParameterType(DbType.String)]
        public string DetailFilterCondition { get; set; }

        #endregion

    }
}
