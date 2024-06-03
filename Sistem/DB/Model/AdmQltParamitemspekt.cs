using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_QLT_PARAMITEMSPEKT için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_QLT_PARAMITEMSPEKT")]
    public class AdmQltParamitemspekt : BaseModel
    {

        #region Constructor

        public AdmQltParamitemspekt()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmQltParamitemspekt_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("ITEMREF")]
        [ParameterType(DbType.Int32)]
        public int? Itemref { get; set; }

        [Field("ITEMCODE")]
        [ParameterType(DbType.String)]
        public string Itemcode { get; set; }

        [Field("ITEMNAME")]
        [ParameterType(DbType.String)]
        public string Itemname { get; set; }

        [Field("PARAMREF")]
        [ParameterType(DbType.Int32)]
        public int? Paramref { get; set; }

        [Field("PARAMCODE")]
        [ParameterType(DbType.String)]
        public string Paramcode { get; set; }

        [Field("PARAMNAME")]
        [ParameterType(DbType.String)]
        public string Paramname { get; set; }

        [Field("PARAMVALREF")]
        [ParameterType(DbType.Int32)]
        public int? Paramvalref { get; set; }

        [Field("PARAMVALCODE")]
        [ParameterType(DbType.String)]
        public string Paramvalcode { get; set; }

        [Field("PARAMVALNAME")]
        [ParameterType(DbType.String)]
        public string Paramvalname { get; set; }

        [Field("PARAMVALUNIT")]
        [ParameterType(DbType.String)]
        public string ParamvalUnit { get; set; }

        [Field("PARAMSPEKTVALUE1")]
        [ParameterType(DbType.String)]
        public string Paramspektvalue1 { get; set; }

        [Field("PARAMSPEKTVALUE2")]
        [ParameterType(DbType.String)]
        public string Paramspektvalue2 { get; set; }

        #endregion

    }
}
