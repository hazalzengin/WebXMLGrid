using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_ERDR_OFFERITEMGROUP_UNITS için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_ERDR_OFFERITEMGROUP_UNITS")]
    public class AdmErdrOfferitemgroupUnits : BaseModel
    {

        #region Constructor

        public AdmErdrOfferitemgroupUnits()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmErdrOfferitemgroupUnits_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("NAME_TR")]
        [ParameterType(DbType.String)]
        public string NameTr { get; set; }

        [Field("NAME_EN")]
        [ParameterType(DbType.String)]
        public string NameEn { get; set; }

        [Field("NAME_FR")]
        [ParameterType(DbType.String)]
        public string NameFr { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        [Field("ORDERNO")]
        [ParameterType(DbType.Int32)]
        public int? Orderno { get; set; }

        #endregion

    }
}
