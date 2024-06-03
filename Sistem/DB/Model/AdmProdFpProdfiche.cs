using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_PROD_FP_PRODFICHE için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_PROD_FP_PRODFICHE")]
    public class AdmProdFpProdfiche : BaseModel
    {

        #region Constructor

        public AdmProdFpProdfiche()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmProdFpProdfiche_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Date_ { get; set; }

        [Field("DOCNUM")]
        [ParameterType(DbType.String)]
        public string Docnum { get; set; }

        [Field("ITEMREF")]
        [ParameterType(DbType.Int32)]
        public int? Itemref { get; set; }

        [Field("ITEMCODE")]
        [ParameterType(DbType.String)]
        public string Itemcode { get; set; }

        [Field("ITEMNAME")]
        [ParameterType(DbType.String)]
        public string Itemname { get; set; }

        [Field("QUANTITY")]
        [ParameterType(DbType.Decimal)]
        public decimal? Quantity { get; set; }

        [Field("PALETICIMIKTAR")]
        [ParameterType(DbType.Decimal)]
        public decimal? Paleticimiktar { get; set; }

        [Field("QUNIT")]
        [ParameterType(DbType.String)]
        public string Qunit { get; set; }

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

        [Field("LOTNUM")]
        [ParameterType(DbType.String)]
        public string Lotnum { get; set; }

        [Field("TOTALSCRAP")]
        [ParameterType(DbType.Decimal)]
        public decimal? Totalscrap { get; set; }

        [Field("PROJECTNO")]
        [ParameterType(DbType.String)]
        public string Projectno { get; set; }

        [Field("COSTCENTER")]
        [ParameterType(DbType.String)]
        public string Costcenter { get; set; }

        [Field("SALNUM")]
        [ParameterType(DbType.String)]
        public string Salnum { get; set; }

        [Field("LINEEXP")]
        [ParameterType(DbType.String)]
        public string Lineexp { get; set; }

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

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISTRANSFERRED")]
        [ParameterType(DbType.Int32)]
        public int? Istransferred { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
