using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_SETTINGS için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_SETTINGS")]
    public class AdmSettings : BaseModel
    {

        #region Constructor

        public AdmSettings()
        {

        }

        public AdmSettings(string firmdef, string tel, string mail, string mailhost, string mailaddr, string mailpass, string mailport, int ismailssl, string sysTo, string sysCc, string logTo, string logCc, int tranmethod, string logosecuritycode, string logofirm, string logoperiod, string logoconnectuser, string logoconnectpass, string logoserviceip)
        {
            this.Firmdef = firmdef;
            this.Tel = tel;
            this.Mail = mail;
            this.Mailhost = mailhost;
            this.Mailaddr = mailaddr;
            this.Mailpass = mailpass;
            this.Mailport = mailport;
            this.Ismailssl = ismailssl;
            this.SysTo = sysTo;
            this.SysCc = sysCc;
            this.LogTo = logTo;
            this.LogCc = logCc;
            this.Tranmethod = tranmethod;
            this.Logosecuritycode = logosecuritycode;
            this.Logofirm = logofirm;
            this.Logoperiod = logoperiod;
            this.Logoconnectuser = logoconnectuser;
            this.Logoconnectpass = logoconnectpass;
            this.Logoserviceip = logoserviceip;

        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmSettings_seq")]
        [Field("LREF")]
        [ParameterType(DbType.Int32)]
        public int Lref { get; set; }

        [Field("FIRMDEF")]
        [ParameterType(DbType.String)]
        public string Firmdef { get; set; }

        [Field("TEL")]
        [ParameterType(DbType.String)]
        public string Tel { get; set; }

        [Field("MAIL")]
        [ParameterType(DbType.String)]
        public string Mail { get; set; }

        [Field("WEBSITE")]
        [ParameterType(DbType.String)]
        public string Website { get; set; }
        [Field("ADDRESS")]
        [ParameterType(DbType.String)]
        public string Address { get; set; }

        [Field("MAILHOST")]
        [ParameterType(DbType.String)]
        public string Mailhost { get; set; }

        [Field("MAILADDR")]
        [ParameterType(DbType.String)]
        public string Mailaddr { get; set; }

        [Field("MAILPASS")]
        [ParameterType(DbType.String)]
        public string Mailpass { get; set; }

        [Field("MAILPORT")]
        [ParameterType(DbType.String)]
        public string Mailport { get; set; }

        [Field("ISMAILSSL")]
        [ParameterType(DbType.Int32)]
        public int Ismailssl { get; set; }

        [Field("SYS_TO")]
        [ParameterType(DbType.String)]
        public string SysTo { get; set; }

        [Field("SYS_CC")]
        [ParameterType(DbType.String)]
        public string SysCc { get; set; }

        [Field("LOG_TO")]
        [ParameterType(DbType.String)]
        public string LogTo { get; set; }

        [Field("LOG_CC")]
        [ParameterType(DbType.String)]
        public string LogCc { get; set; }

        [Field("TRANMETHOD")]
        [ParameterType(DbType.Int32)]
        public int Tranmethod { get; set; }


        [Field("LOGOSECURITYCODE")]
        [ParameterType(DbType.String)]
        public string Logosecuritycode
        {
            get; set;
        }

        [Field("LOGOFIRM")]
        [ParameterType(DbType.String)]
        public String Logofirm
        {
            get; set;
        }

        [Field("LOGODB")]
        [ParameterType(DbType.String)]
        public string Logodb
        {
            get; set;
        }

        [Field("LOGOPERIOD")]
        [ParameterType(DbType.String)]
        public string Logoperiod
        {
            get; set;
        }

        [Field("LOGOCONNECTUSER")]
        [ParameterType(DbType.String)]
        public string Logoconnectuser
        {
            get; set;
        }

        [Field("LOGOCONNECTPASS")]
        [ParameterType(DbType.String)]
        public string Logoconnectpass
        {
            get; set;
        }

        [Field("LOGOSERVICEIP")]
        [ParameterType(DbType.String)]
        public string Logoserviceip
        {
            get; set;
        }

        [Field("LOGOWEBAPIIP")]
        [ParameterType(DbType.String)]
        public string LogoWebApiIp
        {
            get; set;
        }

        [Field("APITOKEN")]
        [ParameterType(DbType.String)]
        public string ApiToken
        {
            get; set;
        }

        [Field("LOGOTRCODE")]
        [ParameterType(DbType.String)]
        public string LogoTrCode
        {
            get; set;
        }

        [Field("LOGOAUXILCODE")]
        [ParameterType(DbType.String)]
        public string LogoAuxilCode
        {
            get; set;
        }

        [Field("SALESBUDGETTYPE")]
        [ParameterType(DbType.Int32)]
        public int Salesbudgettype { get; set; }


        [Field("FINANCEMULTIPLIER")]
        [ParameterType(DbType.Int32)]
        public int Financemultiplier { get; set; }

        [Field("EDITABLERECIPE")]
        [ParameterType(DbType.Int32)]
        public int Editablerecipe { get; set; }


        [Field("PROJDB")]
        [ParameterType(DbType.String)]
        public string ProjDB
        {
            get; set;
        }

        [Field("AUTOGEN_IENO")]
        [ParameterType(DbType.Int32)]
        public int Autogenieno { get; set; }


        [Field("AUTOGEN_IELOTNO")]
        [ParameterType(DbType.Int32)]
        public int Autogenielotno { get; set; }


        [Field("IS_IEWHTRANSFERACTIVE")]
        [ParameterType(DbType.Int32)]
        public int IsIewhtransferactive { get; set; }


        [Field("HAS_WMSMODULE")]
        [ParameterType(DbType.Int32)]
        public int HasWmsmodule { get; set; }

        [Field("HASINTEGRATION")]
        [ParameterType(DbType.Int32)]
        public int HasIntegration { get; set; }


        #endregion

    }
}
