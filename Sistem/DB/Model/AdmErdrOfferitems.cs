using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_ERDR_OFFERITEMS için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_ERDR_OFFERITEMS")]
    public class AdmErdrOfferitems : BaseModel
    {

        #region Constructor

        public AdmErdrOfferitems()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmErdrOfferitems_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("OFFERREF")]
        [ParameterType(DbType.Int32)]
        public int? Offerref { get; set; }

        [Field("GROUPREF")]
        [ParameterType(DbType.Int32)]
        public int? Groupref { get; set; }


        [Field("ITEMLREF")]
        [ParameterType(DbType.Int32)]
        public int? Itemlref { get; set; }

        [Field("ITEMTYPE")]
        [ParameterType(DbType.String)]
        public string Itemtype { get; set; }

        [Field("ITEMCODE")]
        [ParameterType(DbType.String)]
        public string Itemcode { get; set; }

        [Field("ITEMNAME")]
        [ParameterType(DbType.String)]
        public string Itemname { get; set; }

        [Field("ITEMNAMEEN")]
        [ParameterType(DbType.String)]
        public string Itemnameen { get; set; }

        [Field("ITEMNAMEFR")]
        [ParameterType(DbType.String)]
        public string Itemnamefr { get; set; }

        [Field("AMOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Amount { get; set; }

        [Field("UNIT")]
        [ParameterType(DbType.String)]
        public string Unit { get; set; }

        [Field("UNITPRICE")]
        [ParameterType(DbType.Decimal)]
        public decimal? Unitprice { get; set; }

        [Field("UNITPRICECUR")]
        [ParameterType(DbType.Decimal)]
        public decimal? Unitpricecur { get; set; }

        [Field("CURRENCYTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Currencytype { get; set; }

        [Field("CURRENCYRATE")]
        [ParameterType(DbType.Decimal)]
        public decimal? Currencyrate { get; set; }

        [Field("VATRATE")]
        [ParameterType(DbType.Decimal)]
        public decimal? Vatrate { get; set; }

        [Field("VATTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Vattype { get; set; }

        [Field("DISCOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Discount { get; set; }

        [Field("DISCOUNT2")]
        [ParameterType(DbType.Decimal)]
        public decimal? Discount2 { get; set; }

        [Field("DISCOUNT3")]
        [ParameterType(DbType.Decimal)]
        public decimal? Discount3 { get; set; }

        [Field("EXP1")]
        [ParameterType(DbType.String)]
        public string Exp1 { get; set; }

        [Field("EXP2")]
        [ParameterType(DbType.String)]
        public string Exp2 { get; set; }

        [Field("SPECODE1")]
        [ParameterType(DbType.String)]
        public string Specode1 { get; set; }

        [Field("SPECODE2")]
        [ParameterType(DbType.String)]
        public string Specode2 { get; set; }

        [Field("SPECODE3")]
        [ParameterType(DbType.String)]
        public string Specode3 { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

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

        #endregion

    }
}
