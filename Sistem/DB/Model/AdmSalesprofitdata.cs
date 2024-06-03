using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_SALESPROFITDATA için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_SALESPROFITDATA")]
    public class AdmSalesprofitdata
    {

        #region Constructor

        public AdmSalesprofitdata()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmSalesprofitdata_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("FIRMNR")]
        [ParameterType(DbType.String)]
        public string Firmnr { get; set; }

        [Field("PERIOD")]
        [ParameterType(DbType.String)]
        public string Period { get; set; }

        [Field("FICHENO")]
        [ParameterType(DbType.String)]
        public string Ficheno { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.Date)]
        public DateTime Date_ { get; set; }

        [Field("CLCODE")]
        [ParameterType(DbType.String)]
        public string Clcode { get; set; }

        [Field("CLNAME")]
        [ParameterType(DbType.String)]
        public string Clname { get; set; }

        [Field("ITEMCODE")]
        [ParameterType(DbType.String)]
        public string Itemcode { get; set; }

        [Field("ITEMNAME")]
        [ParameterType(DbType.String)]
        public string Itemname { get; set; }

        [Field("LOTNO")]
        [ParameterType(DbType.String)]
        public string Lotno { get; set; }

        [Field("LOTADI")]
        [ParameterType(DbType.String)]
        public string Lotadi { get; set; }

        [Field("AMOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Amount { get; set; }

        [Field("UNIT")]
        [ParameterType(DbType.String)]
        public string Unit { get; set; }

        [Field("PRICE")]
        [ParameterType(DbType.Decimal)]
        public decimal? Price { get; set; }

        [Field("VATMATRAH")]
        [ParameterType(DbType.Decimal)]
        public decimal? Vatmatrah { get; set; }

        [Field("USDPRICE")]
        [ParameterType(DbType.Decimal)]
        public decimal? Usdprice { get; set; }

        [Field("ITMSPECODE")]
        [ParameterType(DbType.String)]
        public string Itmspecode { get; set; }

        [Field("CLSPECODE")]
        [ParameterType(DbType.String)]
        public string Clspecode { get; set; }

        [Field("COSTPRICE")]
        [ParameterType(DbType.Decimal)]
        public decimal? Costprice { get; set; }

        [Field("COSTPRICEUSD")]
        [ParameterType(DbType.Decimal)]
        public decimal? Costpriceusd { get; set; }

        [Field("COST")]
        [ParameterType(DbType.Decimal)]
        public decimal? Cost { get; set; }

        [Field("COSTUSD")]
        [ParameterType(DbType.Decimal)]
        public decimal? Costusd { get; set; }

        [Field("BRUTKAR")]
        [ParameterType(DbType.Decimal)]
        public decimal? Brutkar { get; set; }

        [Field("NETKAR")]
        [ParameterType(DbType.Decimal)]
        public decimal? Netkar { get; set; }

        #endregion

    }
}
