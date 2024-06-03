using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_TMZ_KALIP için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_TMZ_KALIP")]
    public class AdmTmzKalip
    {

        #region Constructor

        public AdmTmzKalip()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmTmzKalip_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("ITEMREF")]
        [ParameterType(DbType.Int32)]
        public int? Itemref { get; set; }

        [Field("ITEMCODE")]
        [ParameterType(DbType.String)]
        public string Itemcode { get; set; }

        [Field("ITEMNAME")]
        [ParameterType(DbType.String)]
        public string Itemname { get; set; }

        [Field("FIRMA")]
        [ParameterType(DbType.String)]
        public string Firma { get; set; }

        [Field("REVIZYON")]
        [ParameterType(DbType.String)]
        public string Revizyon { get; set; }

        [Field("REVIZYON_TARIHI")]
        [ParameterType(DbType.DateTime)]
        public DateTime? RevizyonTarihi { get; set; }

        [Field("EBAT")]
        [ParameterType(DbType.String)]
        public string Ebat { get; set; }

        [Field("MAKINEREF")]
        [ParameterType(DbType.Int32)]
        public int? Makineref { get; set; }

        [Field("MAKINE_CODE")]
        [ParameterType(DbType.String)]
        public string MakineCode { get; set; }

        [Field("CILT")]
        [ParameterType(DbType.String)]
        public string Cilt { get; set; }

        [Field("AMOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Amount { get; set; }

        [Field("DOLAPNO")]
        [ParameterType(DbType.String)]
        public string Dolapno { get; set; }

        [Field("RAFNO")]
        [ParameterType(DbType.String)]
        public string Rafno { get; set; }

        [Field("GIRIS_TARIHI")]
        [ParameterType(DbType.DateTime)]
        public DateTime? GirisTarihi { get; set; }

        [Field("CIKIS_TARIHI")]
        [ParameterType(DbType.DateTime)]
        public DateTime? CikisTarihi { get; set; }

        [Field("EXP")]
        [ParameterType(DbType.String)]
        public string Exp { get; set; }

        [Field("ISBUYUKMAKINE")]
        [ParameterType(DbType.Int32)]
        public int? Isbuyukmakine { get; set; }

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

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
