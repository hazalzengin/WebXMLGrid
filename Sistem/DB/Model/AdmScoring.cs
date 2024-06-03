using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_SCORING için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_SCORING")]
    public class AdmScoring : BaseModel
    {

        #region Constructor

        public AdmScoring()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmScoring_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("CLCARDREF")]
        [ParameterType(DbType.Int32)]
        public int? Clcardref { get; set; }

        [Field("INVREF")]
        [ParameterType(DbType.Int32)]
        public int? Invref { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Date_ { get; set; }

        [Field("USERNAME")]
        [ParameterType(DbType.String)]
        public string Username { get; set; }

        [Field("TRCODE")]
        [ParameterType(DbType.Int32)]
        public int? Trcode { get; set; }

        [Field("DEBIT")]
        [ParameterType(DbType.Double)]
        public double? Debit { get; set; }

        [Field("CREDIT")]
        [ParameterType(DbType.Double)]
        public double? Credit { get; set; }

        #endregion

    }
}
