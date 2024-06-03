using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_PRDITEM_LOT için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_PRDITEM_LOT")]
    public class AdmPrditemLot : BaseModel
    {

        #region Constructor

        public AdmPrditemLot()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmPrditemLot_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("ORDERREF")]
        [ParameterType(DbType.Int32)]
        public int? Orderref { get; set; }

        [Field("OPRREF")]
        [ParameterType(DbType.Int32)]
        public int? Oprref { get; set; }

        [Field("PRDITEMREF")]
        [ParameterType(DbType.Int32)]
        public int? Prditemref { get; set; }

        [Field("ITEMREF")]
        [ParameterType(DbType.Int32)]
        public int? Itemref { get; set; }

        [Field("ITEMCODE")]
        [ParameterType(DbType.String)]
        public string Itemcode { get; set; }

        [Field("ITEMNAME")]
        [ParameterType(DbType.String)]
        public string Itemname { get; set; }

        [Field("SLREF")]
        [ParameterType(DbType.Int32)]
        public int? Slref { get; set; }

        [Field("ACCEPTOPRREF")]
        [ParameterType(DbType.Int32)]
        public int? Acceptoprref { get; set; }

        [Field("LOTREF")]
        [ParameterType(DbType.Int32)]
        public int? Lotref { get; set; }

        [Field("LOTCODE")]
        [ParameterType(DbType.String)]
        public string Lotcode { get; set; }

        [Field("LOTNAME")]
        [ParameterType(DbType.String)]
        public string Lotname { get; set; }

        [Field("QUANTITY")]
        [ParameterType(DbType.Decimal)]
        public decimal? Quantity { get; set; }

        [Field("UNIT")]
        [ParameterType(DbType.String)]
        public string Unit { get; set; }

        [Field("WHREF")]
        [ParameterType(DbType.Int32)]
        public int? Whref { get; set; }

        [Field("WHCODE")]
        [ParameterType(DbType.String)]
        public string Whcode { get; set; }

        [Field("WHNAME")]
        [ParameterType(DbType.String)]
        public string Whname { get; set; }

        [Field("SKT")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Skt { get; set; }

        [Field("ISAUTOTRANSFERRED")]
        [ParameterType(DbType.Int32)]
        public int? Isautotransferred { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
