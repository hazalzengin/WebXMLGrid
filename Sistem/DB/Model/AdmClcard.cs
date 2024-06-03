using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_CLCARD için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_CLCARD")]
    public class AdmClcard : BaseModel
    {

        #region Constructor

        public AdmClcard()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmClcard_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("CODE")]
        [ParameterType(DbType.String)]
        public string Code { get; set; }

        [Field("NAME")]
        [ParameterType(DbType.String)]
        public string Name { get; set; }

        [Field("COUNRTY")]
        [ParameterType(DbType.String)]
        public string Counrty { get; set; }

        [Field("CITY")]
        [ParameterType(DbType.String)]
        public string City { get; set; }

        [Field("ADDRESS")]
        [ParameterType(DbType.String)]
        public string Address { get; set; }

        [Field("PHONE")]
        [ParameterType(DbType.String)]
        public string Phone { get; set; }

        [Field("EMAIL")]
        [ParameterType(DbType.String)]
        public string Email { get; set; }

        [Field("WEBSITE")]
        [ParameterType(DbType.String)]
        public string Website { get; set; }

        [Field("CUSTOMERTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Customertype { get; set; }

        [Field("MOBILE")]
        [ParameterType(DbType.String)]
        public string Mobile { get; set; }

        [Field("TAXADMINISTRATION")]
        [ParameterType(DbType.String)]
        public string Taxadministration { get; set; }

        [Field("TAXNO")]
        [ParameterType(DbType.String)]
        public string Taxno { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
