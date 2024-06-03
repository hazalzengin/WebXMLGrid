using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// WMS_LOCATION için base classý
    /// </summary>
    [Serializable]
    [TableName("WMS_LOCATION")]
    public class WmsLocation : BaseModel
    {

        #region Constructor

        public WmsLocation()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("WmsLocation_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("CODE")]
        [ParameterType(DbType.String)]
        public string Code { get; set; }

        [Field("NAME")]
        [ParameterType(DbType.String)]
        public string Name { get; set; }

        [Field("BARCODE")]
        [ParameterType(DbType.String)]
        public string Barcode { get; set; }

        [Field("BRANCH")]
        [ParameterType(DbType.Int32)]
        public int? Branch { get; set; }

        [Field("SOURCEINDEX")]
        [ParameterType(DbType.Int32)]
        public int? Sourceindex { get; set; }

        [Field("ISMIXED")]
        [ParameterType(DbType.Int32)]
        public int? Ismixed { get; set; }

        [Field("ISSHIPPINGAREA")]
        [ParameterType(DbType.Int32)]
        public int? Isshippingarea { get; set; }

        [Field("ISPURCHASEAREA")]
        [ParameterType(DbType.Int32)]
        public int? Ispurchasearea { get; set; }

        [Field("ISPRODAREA")]
        [ParameterType(DbType.Int32)]
        public int? Isprodearea { get; set; }

        [Field("ISBLOCKED")]
        [ParameterType(DbType.Int32)]
        public int? Isblocked { get; set; }

        [Field("ISCHAPCHECK")]
        [ParameterType(DbType.Int32)]
        public int? Ischapcheck { get; set; }

        [Field("CAPACITY")]
        [ParameterType(DbType.Decimal)]
        public decimal? Capacity { get; set; }

        [Field("UOMREF")]
        [ParameterType(DbType.Int32)]
        public int? Uomref { get; set; }

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

        #endregion

    }
}
