using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_BI_REFERANSFAIZ için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_BI_REFERANSFAIZ")]
    public class AdmBiReferansfaiz : BaseModel
    {

        #region Constructor

        public AdmBiReferansfaiz()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmBiReferansfaiz_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Date_ { get; set; }

        [Field("FAIZTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Faiztype { get; set; }

        [Field("FAIZTURU")]
        [ParameterType(DbType.String)]
        public string Faizturu { get; set; }

        [Field("FAIZORANI")]
        [ParameterType(DbType.Decimal)]
        public decimal? Faizorani { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
