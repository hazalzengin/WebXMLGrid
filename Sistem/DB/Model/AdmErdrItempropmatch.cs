using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_ERDR_ITEMPROPMATCH için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_ERDR_ITEMPROPMATCH")]
    public class AdmErdrItempropmatch : BaseModel
    {

        #region Constructor

        public AdmErdrItempropmatch()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmErdrItempropmatch_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("ITEMTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Itemtype { get; set; }

        [Field("ITEMREF")]
        [ParameterType(DbType.Int32)]
        public int? Itemref { get; set; }

        [Field("ITEMCODE")]
        [ParameterType(DbType.String)]
        public string Itemcode { get; set; }

        [Field("ITEMNAME")]
        [ParameterType(DbType.String)]
        public string Itemname { get; set; }

        [Field("FRAMETYPE")]
        [ParameterType(DbType.String)]
        public string Frametype { get; set; }

        [Field("FRAMESIZE")]
        [ParameterType(DbType.String)]
        public string Framesize { get; set; }

        [Field("FRAMEHEADSIZE")]
        [ParameterType(DbType.String)]
        public string Frameheadsize { get; set; }

        [Field("FRAMECOLOR")]
        [ParameterType(DbType.String)]
        public string Framecolor { get; set; }

        [Field("LEAFTYPE")]
        [ParameterType(DbType.String)]
        public string Leaftype { get; set; }

        [Field("LEAFCOLOR")]
        [ParameterType(DbType.String)]
        public string Leafcolor { get; set; }

        [Field("LEAFMODEL")]
        [ParameterType(DbType.String)]
        public string Leafmodel { get; set; }

        [Field("LEAFSTILE")]
        [ParameterType(DbType.String)]
        public string Leafstile { get; set; }

        [Field("LEAFSIZE")]
        [ParameterType(DbType.String)]
        public string Leafsize { get; set; }

        [Field("LEAFHEIGHT")]
        [ParameterType(DbType.String)]
        public string Leafheight { get; set; }

        [Field("LEAFLOCK")]
        [ParameterType(DbType.String)]
        public string Leaflock { get; set; }

        [Field("SILLTYPE")]
        [ParameterType(DbType.String)]
        public string Silltype { get; set; }

        [Field("SILLSIZE")]
        [ParameterType(DbType.String)]
        public string Sillsize { get; set; }

        [Field("SILLHEIGHT")]
        [ParameterType(DbType.String)]
        public string Sillheight { get; set; }

        [Field("SILLCOLOR")]
        [ParameterType(DbType.String)]
        public string Sillcolor { get; set; }

        [Field("PROP1")]
        [ParameterType(DbType.String)]
        public string Prop1 { get; set; }

        [Field("PROP2")]
        [ParameterType(DbType.String)]
        public string Prop2 { get; set; }

        [Field("PROP3")]
        [ParameterType(DbType.String)]
        public string Prop3 { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
