using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_SHIPORDERITEMS için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_SHIPORDERITEMS")]
    public class AdmShiporderitems : BaseModel
    {

        #region Constructor

        public AdmShiporderitems()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmShiporderitems_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("PARENTREF")]
        [ParameterType(DbType.Int32)]
        public int? Parentref { get; set; }

        [Field("ORDERREF")]
        [ParameterType(DbType.Int32)]
        public int? Orderref { get; set; }

        [Field("ORDERLINEREF")]
        [ParameterType(DbType.Int32)]
        public int? Orderlineref { get; set; }

        [Field("BARCODE")]
        [ParameterType(DbType.String)]
        public string Barcode { get; set; }

        [Field("ITEMREF")]
        [ParameterType(DbType.Int32)]
        public int? Itemref { get; set; }

        [Field("ITEMCODE")]
        [ParameterType(DbType.String)]
        public string Itemcode { get; set; }

        [Field("ITEMNAME")]
        [ParameterType(DbType.String)]
        public string Itemname { get; set; }

        [Field("ITEMUNIT")]
        [ParameterType(DbType.String)]
        public string Itemunit { get; set; }

        [Field("UOMREF")]
        [ParameterType(DbType.Int32)]
        public int? Uomref { get; set; }

        [Field("AMOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Amount { get; set; }

        [Field("PALETTEQUANTITY")]
        [ParameterType(DbType.Decimal)]
        public decimal? Palettequantity { get; set; }

        [Field("PRICE")]
        [ParameterType(DbType.Decimal)]
        public decimal? Price { get; set; }

        [Field("PAYMENT_CODE")]
        [ParameterType(DbType.String)]
        public string PaymentCode { get; set; }

        [Field("ORDER_EXP")]
        [ParameterType(DbType.String)]
        public string OrderExp { get; set; }

        [Field("ISDELIVERED")]
        [ParameterType(DbType.Int32)]
        public int? Isdelivered { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        [Field("FICHELREF")]
        [ParameterType(DbType.Int32)]
        public int? Fichelref { get; set; }

        [Field("FICHENO")]
        [ParameterType(DbType.String)]
        public string Ficheno { get; set; }

        [Field("ISFICHE_CREATED")]
        [ParameterType(DbType.Int32)]
        public int? IsficheCreated { get; set; }

        [Field("FICHE_MSG")]
        [ParameterType(DbType.String)]
        public string FicheMsg { get; set; }

        #endregion

    }
}
