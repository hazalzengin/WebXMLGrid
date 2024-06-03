using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_ROUHEAD için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_ROUHEAD")]
    public class AdmRouhead : BaseModel
    {

        #region Constructor

        public AdmRouhead()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmRouhead_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("CODE")]
        [ParameterType(DbType.String)]
        public string Code { get; set; }

        [Field("NAME")]
        [ParameterType(DbType.String)]
        public string Name { get; set; }

        [Field("BOMREF")]
        [ParameterType(DbType.Int32)]
        public int? Bomref { get; set; }

        [Field("ITEMREF")]
        [ParameterType(DbType.Int32)]
        public int? Itemref { get; set; }

        [Field("ITEMCODE")]
        [ParameterType(DbType.String)]
        public string Itemcode { get; set; }

        [Field("ITEMNAME")]
        [ParameterType(DbType.String)]
        public string Itemname { get; set; }

        [Field("INSERTSUBOPRATIONS")]
        [ParameterType(DbType.Int32)]
        public int? Insertsuboperations { get; set; }

        [Field("UNIT")]
        [ParameterType(DbType.String)]
        public string Unit { get; set; }

        [Field("WAREHOUSEREF")]
        [ParameterType(DbType.Int32)]
        public int? Warehouseref { get; set; }
        [Field("WAREHOUSENAME")]
        [ParameterType(DbType.String)]
        public string Warehousename { get; set; }

        [Field("MINLOT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Minlot { get; set; }

        [Field("MAXLOT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Maxlot { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        [Field("ROUTYPE")]
        [ParameterType(DbType.Int32)]
        public int? RouType { get; set; }

        [Field("ALTERNATIVENO")]
        [ParameterType(DbType.Decimal)]
        public int AlternativeNo { get; set; }
        #endregion

    }
}
