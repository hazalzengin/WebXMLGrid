using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_BOMITEM için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_BOMITEM")]
    public class AdmBomitem : BaseModel
    {

        #region Constructor

        public AdmBomitem()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmBomitem_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("BOMCODE")]
        [ParameterType(DbType.String)]
        public string Bomcode { get; set; }

        [Field("ITEMREF")]
        [ParameterType(DbType.Int32)]
        public int? Itemref { get; set; }

        [Field("ITEMCODE")]
        [ParameterType(DbType.String)]
        public string Itemcode { get; set; }

        [Field("ITEMNAME")]
        [ParameterType(DbType.String)]
        public string Itemname { get; set; }

        [Field("ITEMTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Itemtype { get; set; }

        [Field("ISCALC")]
        [ParameterType(DbType.Int32)]
        public int? Iscalc { get; set; }

        [Field("QUANTITY")]
        [ParameterType(DbType.Decimal)]
        public decimal? Quantity { get; set; }

        [Field("QUNIT")]
        [ParameterType(DbType.String)]
        public string Qunit { get; set; }

        [Field("ISSTOP")]
        [ParameterType(DbType.Int32)]
        public int? Isstop { get; set; }

        [Field("ISRESERVATION")]
        [ParameterType(DbType.Int32)]
        public int? Isreservation { get; set; }

        [Field("ISITEMGROUP")]
        [ParameterType(DbType.Decimal)]
        public int IsItemGroup { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        [Field("ISSABITTUKETIM")]
        [ParameterType(DbType.Decimal)]
        public int IsSabitTuketim { get; set; }

        #endregion

    }
}
