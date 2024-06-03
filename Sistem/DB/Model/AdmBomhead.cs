using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_BOMHEAD için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_BOMHEAD")]
    public class AdmBomhead : BaseModel
    {

        #region Constructor

        public AdmBomhead()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmBomhead_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("CODE")]
        [ParameterType(DbType.String)]
        public string Code { get; set; }

        [Field("NAME")]
        [ParameterType(DbType.String)]
        public string Name { get; set; }

        [Field("ITEMREF")]
        [ParameterType(DbType.Int32)]
        public int? Itemref { get; set; }

        [Field("ITEMCODE")]
        [ParameterType(DbType.String)]
        public string Itemcode { get; set; }

        [Field("ITEMNAME")]
        [ParameterType(DbType.String)]
        public string Itemname { get; set; }

        [Field("MINLOT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Minlot { get; set; }

        [Field("MAXLOT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Maxlot { get; set; }

        [Field("BASEQUANTITY")]
        [ParameterType(DbType.Decimal)]
        public decimal? Basequantity { get; set; }

        [Field("BASEUNIT")]
        [ParameterType(DbType.String)]
        public string Baseunit { get; set; }

        [Field("ALTERNATIVENO")]
        [ParameterType(DbType.Decimal)]
        public int AlternativeNo { get; set; }

        [Field("ISITEMGROUP")]
        [ParameterType(DbType.Decimal)]
        public int IsItemGroup { get; set; }


        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        [Field("BOMTYPE")]
        [ParameterType(DbType.Int32)]
        public int? BomType { get; set; }

        #endregion

    }
}
