using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_TMZ_OFFERITEMS için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_TMZ_OFFERITEMS_EXCEL")]
    public class AdmTmzOfferitemsExcel : BaseModel
    {

        #region Constructor

        public AdmTmzOfferitemsExcel()
        {

        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmTmzOfferitems_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("PARENTREF")]
        [ParameterType(DbType.Int32)]
        public int? Parentref { get; set; }

        [Field("OFFERITEMREF")]
        [ParameterType(DbType.Int32)]
        public int? OfferItemref { get; set; }

        [Field("ISGROUPORBASE")]
        [ParameterType(DbType.Int32)]
        public int? Isgrouporbase { get; set; }

        [Field("ITEMGROUPREF")]
        [ParameterType(DbType.Int32)]
        public int? Itemgroupref { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Date_ { get; set; }

        [Field("DUEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Duedate { get; set; }

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

        [Field("UNIT")]
        [ParameterType(DbType.String)]
        public string Unit { get; set; }

        [Field("UNITPRICE")]
        [ParameterType(DbType.Decimal)]
        public decimal? Unitprice { get; set; }

        [Field("SAYFA_SAYISI")]
        [ParameterType(DbType.Int32)]
        public int? SayfaSayisi { get; set; }

        [Field("ISREVIZYON")]
        [ParameterType(DbType.Int32)]
        public int IsRevizyon { get; set; }

        [Field("ISREPEAT")]
        [ParameterType(DbType.Int32)]
        public int Isrepeat { get; set; }

        [Field("REVIZYON_TARIHI")]
        [ParameterType(DbType.DateTime)]
        public DateTime? RevizyonTarihi { get; set; }

        [Field("REVIZYON_NOT")]
        [ParameterType(DbType.String)]
        public string RevizyonNot { get; set; }

        [Field("CREATEDBY")]
        [ParameterType(DbType.String)]
        public string Createdby { get; set; }

        [Field("CREATEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Createdate { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        [Field("GROUPCODE")]
        [ParameterType(DbType.String)]
        public string Groupcode { get; set; }

        [Field("REFITEMCODE")]
        [ParameterType(DbType.String)]
        public string Refitemcode { get; set; }

        [Field("MUSTERISIPARISNO")]
        [ParameterType(DbType.String)]
        public string MusteriSiparisNo { get; set; }

        [Field("SIPARISNOTU")]
        [ParameterType(DbType.String)]
        public string SiparisNotu { get; set; }


        #endregion

    }
}
