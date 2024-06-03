using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_WORKORDER için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_WORKORDER")]
    public class AdmWorkorder : BaseModel
    {

        #region Constructor

        public AdmWorkorder()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmWorkorder_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Date_ { get; set; }
        [Field("DUEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Duedate { get; set; }

        [Field("WORKSTATIONREF")]
        [ParameterType(DbType.Int32)]
        public int? Workstationref { get; set; }

        [Field("PRIORITYREF")]
        [ParameterType(DbType.Int32)]
        public int? Priorityref { get; set; }

        [Field("STATUSREF")]
        [ParameterType(DbType.Int32)]
        public int? Statusref { get; set; }

        [Field("AMOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Amount { get; set; }

        [Field("PRODDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Proddate { get; set; }
        [Field("PRODAMOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Prodamount { get; set; }

        [Field("EXP")]
        [ParameterType(DbType.String)]
        public string Exp { get; set; }

        [Field("PRODEXP")]
        [ParameterType(DbType.String)]
        public string Prodexp { get; set; }

        [Field("ORDERREF")]
        [ParameterType(DbType.Int32)]
        public int? Orderref { get; set; }

        [Field("ORDERITEMREF")]
        [ParameterType(DbType.Int32)]
        public int? Orderitemref { get; set; }

        [Field("WAREHOUSEREF")]
        [ParameterType(DbType.Int32)]
        public int? Warehouseref { get; set; }

        [Field("WAREHOUSENAME")]
        [ParameterType(DbType.String)]
        public string Warehousename { get; set; }

        [Field("ITEMREF")]
        [ParameterType(DbType.Int32)]
        public int? Itemref { get; set; }

        [Field("ITEMCODE")]
        [ParameterType(DbType.String)]
        public string Itemcode { get; set; }

        [Field("ITEMNAME")]
        [ParameterType(DbType.String)]
        public string Itemname { get; set; }

        [Field("CLCARDREF")]
        [ParameterType(DbType.Int32)]
        public int? Clcardref { get; set; }

        [Field("CLCARDCODE")]
        [ParameterType(DbType.String)]
        public string Clcardcode { get; set; }

        [Field("CLCARDNAME")]
        [ParameterType(DbType.String)]
        public string Clcardname { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        [Field("TRANSFERMESSAGE")]
        [ParameterType(DbType.String)]
        public string TransferMessage { get; set; }

        #endregion

    }
}
