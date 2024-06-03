using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_OFFERCREDITTRANS için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_OFFERCREDITTRANS")]
    public class AdmOffercredittrans : BaseModel
    {

        #region Constructor

        public AdmOffercredittrans()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmOffercredittrans_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Date_ { get; set; }

        [Field("CREDITREF")]
        [ParameterType(DbType.Int32)]
        public int? Creditref { get; set; }

        [Field("CROSSREF")]
        [ParameterType(DbType.Int32)]
        public int? Crossref { get; set; }

        [Field("CROSSNO")]
        [ParameterType(DbType.String)]
        public string Crossno { get; set; }

        [Field("TRCODE")]
        [ParameterType(DbType.String)]
        public string Trcode { get; set; }

        [Field("IOCODE")]
        [ParameterType(DbType.Int32)]
        public int? Iocode { get; set; }

        [Field("AMOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Amount { get; set; }

        [Field("CREATEDBY")]
        [ParameterType(DbType.String)]
        public string Createdby { get; set; }

        [Field("CREATEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Createdate { get; set; }

        [Field("UPDATEDBY")]
        [ParameterType(DbType.String)]
        public string Updatedby { get; set; }

        [Field("UPDATEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Updatedate { get; set; }

        [Field("DELETEDBY")]
        [ParameterType(DbType.String)]
        public string Deletedby { get; set; }

        [Field("DELETEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Deletedate { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
