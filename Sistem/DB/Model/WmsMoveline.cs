using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// WMS_MOVELINE için base classý
    /// </summary>
    [Serializable]
    [TableName("WMS_MOVELINE")]
    public class WmsMoveline : BaseModel
    {

        #region Constructor

        public WmsMoveline()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("WmsMoveline_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("FICHEREF")]
        [ParameterType(DbType.Int32)]
        public int? Ficheref { get; set; }

        [Field("TRCODE")]
        [ParameterType(DbType.Int32)]
        public int? Trcode { get; set; }

        [Field("IOCODE")]
        [ParameterType(DbType.Int32)]
        public int? Iocode { get; set; }

        [Field("ITEMREF")]
        [ParameterType(DbType.Int32)]
        public int? Itemref { get; set; }

        [Field("ITEMCODE")]
        [ParameterType(DbType.String)]
        public string Itemcode { get; set; }

        [Field("ITEMNAME")]
        [ParameterType(DbType.String)]
        public string Itemname { get; set; }

        [Field("AMOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Amount { get; set; }

        [Field("UOMREF")]
        [ParameterType(DbType.Int32)]
        public int? Uomref { get; set; }

        [Field("CONVFACT1")]
        [ParameterType(DbType.Int32)]
        public int? Convfact1 { get; set; }

        [Field("CONVFACT2")]
        [ParameterType(DbType.Int32)]
        public int? Convfact2 { get; set; }

        [Field("ISDELETE")]
        [ParameterType(DbType.Int32)]
        public int? Isdelete { get; set; }

        [Field("LOCATIONREF")]
        [ParameterType(DbType.Int32)]
        public int? Locationref { get; set; }

        [Field("BARCODE")]
        [ParameterType(DbType.String)]
        public string Barcode { get; set; }

        [Field("BRANCH")]
        [ParameterType(DbType.Int32)]
        public int? Branch { get; set; }

        [Field("SOURCEINDEX")]
        [ParameterType(DbType.Int32)]
        public int? Sourceindex { get; set; }

        [Field("ISTRANSFERRED")]
        [ParameterType(DbType.Int32)]
        public int? Istransferred { get; set; }

        [Field("LLINEREF")]
        [ParameterType(DbType.Int32)]
        public int? Llineref { get; set; }

        [Field("SOURCEHEADREF")]
        [ParameterType(DbType.Int32)]
        public int? Sourceheadref { get; set; }

        [Field("WMSPARENTREF")]
        [ParameterType(DbType.Int32)]
        public int? WmsParentref { get; set; }

        [Field("SOURCELINEREF")]
        [ParameterType(DbType.Int32)]
        public int? Sourcelineref { get; set; }

        [Field("UNITPRICE")]
        [ParameterType(DbType.Decimal)]
        public decimal? Unitprice { get; set; }

        [Field("CURRENCY")]
        [ParameterType(DbType.String)]
        public string Currency { get; set; }

        [Field("CREATEDAT")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Createdat { get; set; }

        [Field("CREATEDBY")]
        [ParameterType(DbType.String)]
        public string Createdby { get; set; }

        [Field("CHANGEDAT")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Changedat { get; set; }

        [Field("CHANGEDBY")]
        [ParameterType(DbType.String)]
        public string Changedby { get; set; }

        [Field("WMSLINESTRAREA1")]
        [ParameterType(DbType.String)]
        public string WmsLineStrArea1 { get; set; }

        [Field("WMSLINESTRAREA2")]
        [ParameterType(DbType.String)]
        public string WmsLineStrArea2 { get; set; }

        [Field("WMSLINESTRAREA3")]
        [ParameterType(DbType.String)]
        public string WmsLineStrArea3 { get; set; }

        [Field("QLTAPPROVEDSTATUS")]
        [ParameterType(DbType.Int32)]
        public int? Qltapprovedstatus { get; set; }

        #endregion

    }
}
