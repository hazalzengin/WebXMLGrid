using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_COMPANY için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_COMPANY")]
    public class AdmCompany : BaseModel
    {

        #region Constructor

        public AdmCompany()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmCompany_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("LOGOFIRMNR")]
        [ParameterType(DbType.String)]
        public string Logofirmnr { get; set; }

        [Field("CODE")]
        [ParameterType(DbType.String)]
        public string Code { get; set; }

        [Field("FIRMDEF")]
        [ParameterType(DbType.String)]
        public string Firmdef { get; set; }

        [Field("PHONE1")]
        [ParameterType(DbType.String)]
        public string Phone1 { get; set; }

        [Field("PHONE2")]
        [ParameterType(DbType.String)]
        public string Phone2 { get; set; }

        [Field("PHONE3")]
        [ParameterType(DbType.String)]
        public string Phone3 { get; set; }

        [Field("FAX")]
        [ParameterType(DbType.String)]
        public string Fax { get; set; }

        [Field("EMAIL1")]
        [ParameterType(DbType.String)]
        public string Email1 { get; set; }

        [Field("EMAIL2")]
        [ParameterType(DbType.String)]
        public string Email2 { get; set; }

        [Field("WEBSITE")]
        [ParameterType(DbType.String)]
        public string Website { get; set; }

        [Field("ADDRESS")]
        [ParameterType(DbType.String)]
        public string Address { get; set; }

        [Field("CITY")]
        [ParameterType(DbType.String)]
        public string City { get; set; }

        [Field("COUNTRY")]
        [ParameterType(DbType.String)]
        public string Country { get; set; }

        [Field("TAXNO")]
        [ParameterType(DbType.String)]
        public string Taxno { get; set; }

        [Field("TAXADMINISTRATOR")]
        [ParameterType(DbType.String)]
        public string Taxadministrator { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
