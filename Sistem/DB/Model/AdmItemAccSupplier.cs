using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_ITEM_ACC_SUPPLIER için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_ITEM_ACC_SUPPLIER")]
    public class AdmItemAccSupplier : BaseModel
    {

        #region Constructor

        public AdmItemAccSupplier()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmItemAccSupplier_seq")]
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

        [Field("FIRMREF")]
        [ParameterType(DbType.Int32)]
        public int? Firmref { get; set; }

        [Field("FIRMCODE")]
        [ParameterType(DbType.String)]
        public string Firmcode { get; set; }

        [Field("FIRMNAME")]
        [ParameterType(DbType.String)]
        public string Firmname { get; set; }

        [Field("SUPPGROUP")]
        [ParameterType(DbType.String)]
        public string Suppgroup { get; set; }

        [Field("EXP")]
        [ParameterType(DbType.String)]
        public string Exp { get; set; }

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

        #endregion

    }
}
