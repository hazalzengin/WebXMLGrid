using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_QLT_HEAD için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_QLT_HEAD")]
    public class AdmQltHead : BaseModel
    {

        #region Constructor

        public AdmQltHead()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmQltHead_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("QLTTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Qlttype { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Date_ { get; set; }

        [Field("ANALYSISNO")]
        [ParameterType(DbType.String)]
        public string Analysisno { get; set; }

        [Field("ANALYSISDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Analysisdate { get; set; }

        [Field("PARAMREF")]
        [ParameterType(DbType.Int32)]
        public int? Paramref { get; set; }

        [Field("ORDERDATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Orderdate_ { get; set; }

        [Field("ORDERDUEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Orderduedate { get; set; }

        [Field("FICHENO")]
        [ParameterType(DbType.String)]
        public string Ficheno { get; set; }

        [Field("STFICHEREF")]
        [ParameterType(DbType.Int32)]
        public int? Stficheref { get; set; }

        [Field("STLINEREF")]
        [ParameterType(DbType.Int32)]
        public int? Stlineref { get; set; }

        [Field("SLREF")]
        [ParameterType(DbType.Int32)]
        public int? Slref { get; set; }

        [Field("SLCODE")]
        [ParameterType(DbType.String)]
        public string Slcode { get; set; }

        [Field("SLNAME")]
        [ParameterType(DbType.String)]
        public string Slname { get; set; }

        [Field("ITEMREF")]
        [ParameterType(DbType.Int32)]
        public int? Itemref { get; set; }

        [Field("ITEMCODE")]
        [ParameterType(DbType.String)]
        public string Itemcode { get; set; }

        [Field("ITEMNAME")]
        [ParameterType(DbType.String)]
        public string Itemname { get; set; }

        [Field("UNIT")]
        [ParameterType(DbType.String)]
        public string Unit { get; set; }

        [Field("QUANTITY")]
        [ParameterType(DbType.Decimal)]
        public decimal? Quantity { get; set; }

        [Field("SLQUANTITY")]
        [ParameterType(DbType.Decimal)]
        public decimal? SlQuantity { get; set; }

        [Field("WHNO")]
        [ParameterType(DbType.String)]
        public string Whno { get; set; }

        [Field("WHNAME")]
        [ParameterType(DbType.String)]
        public string Whname { get; set; }

        [Field("CLREF")]
        [ParameterType(DbType.Int32)]
        public int? Clref { get; set; }

        [Field("CLCODE")]
        [ParameterType(DbType.String)]
        public string Clcode { get; set; }

        [Field("CLNAME")]
        [ParameterType(DbType.String)]
        public string Clname { get; set; }

        [Field("EXP")]
        [ParameterType(DbType.String)]
        public string Exp { get; set; }

        [Field("CREATEDBY")]
        [ParameterType(DbType.String)]
        public string Createdby { get; set; }

        [Field("CREATEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Createdate { get; set; }

        [Field("UPDATEDBY")]
        [ParameterType(DbType.String)]
        public string Updatedby { get; set; }

        [Field("UPDATEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Updatedate { get; set; }

        [Field("DELETEDBY")]
        [ParameterType(DbType.String)]
        public string Deletedby { get; set; }

        [Field("DELETEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Deletedate { get; set; }

        [Field("QLTSTATUS")]
        [ParameterType(DbType.Int32)]
        public int? Qltstatus { get; set; }

        [Field("ACCEPTEDBY")]
        [ParameterType(DbType.String)]
        public string Acceptedby { get; set; }

        [Field("ACCEPTEDDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Accepteddate { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }



        #endregion

    }
}
