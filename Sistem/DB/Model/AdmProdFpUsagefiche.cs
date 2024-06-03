using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_PROD_FP_USAGEFICHE için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_PROD_FP_USAGEFICHE")]
    public class AdmProdFpUsagefiche : BaseModel
    {

        #region Constructor

        public AdmProdFpUsagefiche()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmProdFpUsagefiche_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Date_ { get; set; }

        [Field("DOCNUM")]
        [ParameterType(DbType.String)]
        public string Docnum { get; set; }

        [Field("WAREHOUSEREF")]
        [ParameterType(DbType.Int32)]
        public int? Warehouseref { get; set; }

        [Field("WAREHOUSECODE")]
        [ParameterType(DbType.String)]
        public string Warehousecode { get; set; }

        [Field("WAREHOUSENAME")]
        [ParameterType(DbType.String)]
        public string Warehousename { get; set; }

        [Field("SHIFTREF")]
        [ParameterType(DbType.Int32)]
        public int? Shiftref { get; set; }

        [Field("PERSONNELREF")]
        [ParameterType(DbType.Int32)]
        public int? Personnelref { get; set; }

        [Field("PROJECTNO")]
        [ParameterType(DbType.String)]
        public string Projectno { get; set; }

        [Field("COSTCENTER")]
        [ParameterType(DbType.String)]
        public string Costcenter { get; set; }

        [Field("SALNUM")]
        [ParameterType(DbType.String)]
        public string Salnum { get; set; }

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

        [Field("ISTRANSFERRED")]
        [ParameterType(DbType.Int32)]
        public int? Istransferred { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
