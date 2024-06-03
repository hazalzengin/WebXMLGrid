using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_LOADINGORDERITEMS için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_LOADINGORDERITEMS")]
    public class AdmLoadingorderitems : BaseModel
    {

        #region Constructor

        public AdmLoadingorderitems()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmLoadingorderitems_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("LOADINGORDERREF")]
        [ParameterType(DbType.Int32)]
        public int? Loadingorderref { get; set; }

        [Field("ORDERREF")]
        [ParameterType(DbType.Int32)]
        public int? Orderref { get; set; }

        [Field("ORDERITEMREF")]
        [ParameterType(DbType.Int32)]
        public int? Orderitemref { get; set; }

        [Field("ITEMCODE")]
        [ParameterType(DbType.String)]
        public string Itemcode { get; set; }

        [Field("ITEMNAME")]
        [ParameterType(DbType.String)]
        public string Itemname { get; set; }

        [Field("ITEMUNIT")]
        [ParameterType(DbType.String)]
        public string Itemunit { get; set; }

        [Field("CLCARDCODE")]
        [ParameterType(DbType.String)]
        public string Clcardcode { get; set; }

        [Field("CLCARDNAME")]
        [ParameterType(DbType.String)]
        public string Clcardname { get; set; }

        [Field("AMOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Amount { get; set; }

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

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        [Field("FICHELREF")]
        [ParameterType(DbType.String)]
        public string Fichelref { get; set; }

        [Field("INVOICELREF")]
        [ParameterType(DbType.Int32)]
        public int? Invoicelref { get; set; }

        [Field("FICHENO")]
        [ParameterType(DbType.String)]
        public string Ficheno { get; set; }

        [Field("ISFICHE_CREATED")]
        [ParameterType(DbType.Int32)]
        public int? IsficheCreated { get; set; }

        [Field("ISINVOICE_CREATED")]
        [ParameterType(DbType.Int32)]
        public int? IsinvoiceCreated { get; set; }

        [Field("FICHE_MSG")]
        [ParameterType(DbType.String)]
        public string FicheMsg { get; set; }

        [Field("INVOICE_MSG")]
        [ParameterType(DbType.String)]
        public string InvoiceMsg { get; set; }

        #endregion

    }
}
