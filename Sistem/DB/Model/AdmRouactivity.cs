using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_ROUACTIVITY için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_ROUACTIVITY")]
    public class AdmRouactivity
    {

        #region Constructor

        public AdmRouactivity()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmRouactivity_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("CODE")]
        [ParameterType(DbType.String)]
        public string Code { get; set; }

        [Field("NAME")]
        [ParameterType(DbType.String)]
        public string Name { get; set; }

        [Field("ACTUNIT")]
        [ParameterType(DbType.Int32)]
        public int? Actunit { get; set; }

        [Field("ACTUNITNAME")]
        [ParameterType(DbType.String)]
        public string Actunitname { get; set; }

        [Field("ISSETUP")]
        [ParameterType(DbType.Int32)]
        public int? Issetup { get; set; }

        [Field("ISMACHINE")]
        [ParameterType(DbType.Int32)]
        public int? Ismachine { get; set; }

        [Field("ISLABOUR")]
        [ParameterType(DbType.Int32)]
        public int? Islabour { get; set; }

        [Field("ACTACCOUNT")]
        [ParameterType(DbType.Int32)]
        public int? Actaccount { get; set; }

        [Field("ACTACCOUNTNAME")]
        [ParameterType(DbType.String)]
        public string Actaccountname { get; set; }

        [Field("CREATEDBY")]
        [ParameterType(DbType.String)]
        public string Createdby { get; set; }

        [Field("CREATEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Createdate { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
