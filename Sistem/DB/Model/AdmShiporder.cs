using System;
using System.Collections.Generic;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_SHIPORDER için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_SHIPORDER")]
    public class AdmShiporder : BaseModel
    {

        #region Constructor

        public AdmShiporder()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmShiporder_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Date_ { get; set; }

        [Field("CLCARDREF")]
        [ParameterType(DbType.Int32)]
        public int? Clcardref { get; set; }

        [Field("CLCARDCODE")]
        [ParameterType(DbType.String)]
        public string Clcardcode { get; set; }

        [Field("CLCARDNAME")]
        [ParameterType(DbType.String)]
        public string Clcardname { get; set; }

        [Field("FICHENO")]
        [ParameterType(DbType.String)]
        public string Ficheno { get; set; }

        [Field("FICHEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? FicheDate { get; set; }

        [Field("TRACKNO")]
        [ParameterType(DbType.String)]
        public string Trackno { get; set; }

        [Field("DRIVERID")]
        [ParameterType(DbType.String)]
        public string Driverid { get; set; }

        [Field("DRIVERNAME")]
        [ParameterType(DbType.String)]
        public string Drivername { get; set; }

        [Field("DRIVERSURNAME")]
        [ParameterType(DbType.String)]
        public string Driversurname { get; set; }    
        
        [Field("DRIVERPHONE")]
        [ParameterType(DbType.String)]
        public string Driverphone { get; set; }

        [Field("EXP")]
        [ParameterType(DbType.String)]
        public string Exp { get; set; }

        [Field("ITEMSELECTTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Itemselecttype { get; set; }

        [Field("STATUSREF")]
        [ParameterType(DbType.Int32)]
        public int? Statusref { get; set; }

        [Field("ORDERTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Ordertype { get; set; }

        [Field("SALESTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Salestype { get; set; }

        [Field("CITY")]
        [ParameterType(DbType.String)]
        public string City { get; set; }

        [Field("BRANCHREF")]
        [ParameterType(DbType.Int32)]
        public int? Branchref { get; set; }

        [Field("BRANCHCODE")]
        [ParameterType(DbType.String)]
        public string Branchcode { get; set; }

        [Field("BRANCHNAME")]
        [ParameterType(DbType.String)]
        public string Branchname { get; set; }

        [Field("WAREHOUSEREF")]
        [ParameterType(DbType.Int32)]
        public int? Warehouseref { get; set; }

        [Field("WAREHOUSECODE")]
        [ParameterType(DbType.String)]
        public string Warehousecode { get; set; }

        [Field("WAREHOUSENAME")]
        [ParameterType(DbType.String)]
        public string Warehousename { get; set; }

        [Field("UPDATEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Updatedate { get; set; }

        [Field("UPDATEDBY")]
        [ParameterType(DbType.String)]
        public string Updatedby { get; set; }

        [Field("CREATEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Createdate { get; set; }

        [Field("CREATEDBY")]
        [ParameterType(DbType.String)]
        public string Createdby { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        [Field("TRANSFERMESSAGE")]
        [ParameterType(DbType.String)]
        public string Transfermessage { get; set; }

        [NoMapping]
        public List<AdmShiporderitems> Items{ get; set; }

        #endregion

    }
}
