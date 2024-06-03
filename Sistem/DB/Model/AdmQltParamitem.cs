using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_QLT_PARAMITEM için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_QLT_PARAMITEM")]
    public class AdmQltParamitem : BaseModel
    {

        #region Constructor

        public AdmQltParamitem()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmQltParamitem_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("PARAMREF")]
        [ParameterType(DbType.Int32)]
        public int? Paramref { get; set; }

        [Field("ITEMREF")]
        [ParameterType(DbType.Int32)]
        public int? Itemref { get; set; }

        [Field("ITEMCODE")]
        [ParameterType(DbType.String)]
        public string Itemcode { get; set; }

        [Field("ITEMNAME")]
        [ParameterType(DbType.String)]
        public string Itemname { get; set; }

        #endregion

    }
}
