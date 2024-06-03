using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_PRDTYPE için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_PRDTYPE")]
    public class AdmPrdtype : BaseModel
    {

        #region Constructor

        public AdmPrdtype()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmPrdtype_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("CODE")]
        [ParameterType(DbType.String)]
        public string Code { get; set; }

        [Field("DEFINITION_")]
        [ParameterType(DbType.String)]
        public string Definition_ { get; set; }

        [Field("ISCOLLECTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Iscollective { get; set; }

        [Field("ISCONFIRMMORE")]
        [ParameterType(DbType.Int32)]
        public int? Isconfirmmore { get; set; }

        [Field("ISMAINTENANCE")]
        [ParameterType(DbType.Int32)]
        public int? Ismaintenance { get; set; }

        [Field("ISSERVICEORDER")]
        [ParameterType(DbType.Int32)]
        public int? Isserviceorder { get; set; }

        [Field("ISSTOCKCONTROL")]
        [ParameterType(DbType.Int32)]
        public int? Isstockcontrol { get; set; }

        [Field("ISCALCULATE")]
        [ParameterType(DbType.Int32)]
        public int? Iscalculate { get; set; }

        [Field("ISQUALITYCONTROL")]
        [ParameterType(DbType.Int32)]
        public int? Isqualitycontrol { get; set; }

        [Field("ISSTARTSTOP")]
        [ParameterType(DbType.Int32)]
        public int? Isstartstop { get; set; }

        [Field("ISEASYCONFIRM")]
        [ParameterType(DbType.Int32)]
        public int? Iseasyconfirm { get; set; }

        [Field("ISSUPPLYFIRST")]
        [ParameterType(DbType.Int32)]
        public int? Issupplyfirst { get; set; }

        [Field("COSTLEVEL")]
        [ParameterType(DbType.Int32)]
        public int? Costlevel { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        [Field("AUTOOUTPUT")]
        [ParameterType(DbType.Int32)]
        public int? AutoOutPut { get; set; }

        [Field("OUTPUTIP")]
        [ParameterType(DbType.String)]
        public string OutPutIp { get; set; }

        [Field("BARCODEFROMLOT")]
        [ParameterType(DbType.Int32)]
        public int? BarcodeFromLot { get; set; }

        [Field("BARCODELEN")]
        [ParameterType(DbType.Int32)]
        public int? BarcodeLen { get; set; }

        [Field("ISERPTRANSFER")]
        [ParameterType(DbType.Int32)]
        public int? IsErpTransfer { get; set; }
        #endregion

    }
}
