using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_ERDR_OFFERITEMGROUP_NAMES i�in base class�
    /// </summary>
    [Serializable]
    [TableName("ADM_ERDR_OFFERITEMGROUP_NAMES")]
    public class AdmErdrOfferitemgroupNames : BaseModel
    {

        #region Constructor

        public AdmErdrOfferitemgroupNames()
        {
        
        }

        #endregion

        #region Tablonun columnlar�

        [PK]
        [Identity("AdmErdrOfferitemgroupNames_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("MARKA")]
        [ParameterType(DbType.String)]
        public string Marka { get; set; }

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
