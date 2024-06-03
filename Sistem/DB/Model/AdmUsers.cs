using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_USERS için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_USERS")]
    public class AdmUsers : BaseModel
    {

        #region Constructor

        public AdmUsers()
        {
        
        }

        public AdmUsers( string username,  string password,  string namesurname,  string email,  string theme,  int approval,  int isadmin,  int isactive,  int isdel)
        {
            this.Username = username;
            this.Password = password;
            this.Namesurname = namesurname;
            this.Email = email;
            this.Theme = theme;
            this.Approval = approval;
            this.Isadmin = isadmin;
            this.Isactive = isactive;
            this.Isdel = isdel;

        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmUsers_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("USERNAME")]
        [ParameterType(DbType.String)]
        public string Username { get; set; }

        [Field("WFUSERCODE")]
        [ParameterType(DbType.String)]
        public string WfUserCode { get; set; }

        [Field("PASSWORD")]
        [ParameterType(DbType.String)]
        public string Password { get; set; }

        [Field("NAMESURNAME")]
        [ParameterType(DbType.String)]
        public string Namesurname { get; set; }

        [Field("EMAIL")]
        [ParameterType(DbType.String)]
        public string Email { get; set; }

        [Field("PHONENO")]
        [ParameterType(DbType.String)]
        public string PhoneNo { get; set; }

        [Field("THEME")]
        [ParameterType(DbType.String)]
        public string Theme { get; set; }

        [Field("APPROVAL")]
        [ParameterType(DbType.Int32)]
        public int Approval { get; set; }

        [Field("ISADMIN")]
        [ParameterType(DbType.Int32)]
        public int Isadmin { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int Isdel { get; set; }


        [Field("ADDRESS")]
        [ParameterType(DbType.String)]
        public string Address { get; set; }

        [Field("USERTYPE")]
        [ParameterType(DbType.Int32)]
        public int Usertype { get; set; }

        [Field("SALESMANCODE")]
        [ParameterType(DbType.String)]
        public string Salesmancode { get; set; }

        [Field("MAILSENDTYPE")]
        [ParameterType(DbType.String)]
        public string MailSendType { get; set; }

        [Field("DEPARTMENTREF")]
        [ParameterType(DbType.Int32)]
        public int Departmentref { get; set; }

        [Field("STARTPAGE")]
        [ParameterType(DbType.String)]
        public string Startpage { get; set; }

        [Field("AUTH_WAREHOUSE")]
        [ParameterType(DbType.String)]
        public string AuthWarehouse { get; set; }

        [Field("AUTHPROJECT")]
        [ParameterType(DbType.String)]
        public string AuthProjects { get; set; }

        #endregion

    }
}
