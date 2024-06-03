using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_PARAMS için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_PARAMS")]
    public class AdmParams : BaseModel
    {

        #region Constructor

        public AdmParams()
        {
        
        }

        public AdmParams( string ptype,  string pcode,  int isactive)
        {
            this.Ptype = ptype;
            this.Pcode = pcode;
            this.Isactive = isactive;

        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmParams_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("PTYPE")]
        [ParameterType(DbType.String)]
        public string Ptype { get; set; }

        [Field("PCODE")]
        [ParameterType(DbType.String)]
        public string Pcode { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int IsDel { get; set; }

        #endregion

    }
}
