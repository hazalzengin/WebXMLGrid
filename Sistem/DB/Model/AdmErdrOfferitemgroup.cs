using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_ERDR_OFFERITEMGROUP için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_ERDR_OFFERITEMGROUP")]
    public class AdmErdrOfferitemgroup : BaseModel
    {

        #region Constructor

        public AdmErdrOfferitemgroup()
        {

        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmErdrOfferitemgroup_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("OFFERREF")]
        [ParameterType(DbType.Int32)]
        public int? Offerref { get; set; }

        [Field("NAME")]
        [ParameterType(DbType.String)]
        public string Name { get; set; }

        [Field("EXP")]
        [ParameterType(DbType.String)]
        public string Exp { get; set; }

        [Field("AMOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Amount { get; set; }

        [Field("UNIT")]
        [ParameterType(DbType.String)]
        public string Unit { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        [Field("ORDERNO")]
        [ParameterType(DbType.Int32)]
        public int? Orderno { get; set; }

        #endregion

    }
}
