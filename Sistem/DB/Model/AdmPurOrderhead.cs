using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_PUR_ORDERHEAD için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_PUR_ORDERHEAD")]
    public class AdmPurOrderhead : BaseModel
    {

        #region Constructor

        public AdmPurOrderhead()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmPurOrderhead_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Date_ { get; set; }

        [Field("DUEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Duedate { get; set; }

        [Field("DEMANDREF")]
        [ParameterType(DbType.Int32)]
        public int? Demandref { get; set; }

        [Field("OFFERREF")]
        [ParameterType(DbType.Int32)]
        public int? Offerref { get; set; }

        [Field("FIRMREF")]
        [ParameterType(DbType.Int32)]
        public int? Firmref { get; set; }

        [Field("FIRMCODE")]
        [ParameterType(DbType.String)]
        public string Firmcode { get; set; }

        [Field("FIRMNAME")]
        [ParameterType(DbType.String)]
        public string Firmname { get; set; }

        [Field("PERSONNELREF")]
        [ParameterType(DbType.Int32)]
        public int? Personnelref { get; set; }

        [Field("DEPARTMENTREF")]
        [ParameterType(DbType.Int32)]
        public int? Departmentref { get; set; }

        [Field("PRIORITY")]
        [ParameterType(DbType.Int32)]
        public int? Priority { get; set; }

        [Field("PROJECTCODE")]
        [ParameterType(DbType.String)]
        public string Projectcode { get; set; }

        [Field("SALESMANCODE")]
        [ParameterType(DbType.String)]
        public string Salesmancode { get; set; }

        [Field("COSTCENTERREF")]
        [ParameterType(DbType.Int32)]
        public int? Costcenterref { get; set; }

        [Field("COSTCENTERCODE")]
        [ParameterType(DbType.String)]
        public string Costcentercode { get; set; }

        [Field("COSTCENTERNAME")]
        [ParameterType(DbType.String)]
        public string Costcentername { get; set; }

        [Field("DELIVERTYPE")]
        [ParameterType(DbType.String)]
        public string Delivertype { get; set; }

        [Field("PAYMENTTYPE")]
        [ParameterType(DbType.String)]
        public string Paymenttype { get; set; }

        [Field("CROSSORDERNO")]
        [ParameterType(DbType.String)]
        public string Crossorderno { get; set; }

        [Field("EXP")]
        [ParameterType(DbType.String)]
        public string Exp { get; set; }

        [Field("PURCHASETYPE")]
        [ParameterType(DbType.Int32)]
        public int? Purchasetype { get; set; }

        [Field("ORDERSTATUS")]
        [ParameterType(DbType.Int32)]
        public int? Orderstatus { get; set; }

        [Field("APPROVESTATUS")]
        [ParameterType(DbType.Int32)]
        public int? Approvestatus { get; set; }

        [Field("APPROVEDBY")]
        [ParameterType(DbType.String)]
        public string Approvedby { get; set; }

        [Field("APPROVEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Approvedate { get; set; }

        [Field("LGREF")]
        [ParameterType(DbType.String)]
        public string Lgref { get; set; }

        [Field("TRANSFERSTATUS")]
        [ParameterType(DbType.Int32)]
        public int? Transferstatus { get; set; }

        [Field("TRANSFERMESSAGE")]
        [ParameterType(DbType.String)]
        public string Transfermessage { get; set; }

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

        [Field("DELIVERYCOST")]
        [ParameterType(DbType.Decimal)]
        public decimal? DeliveryCost { get; set; }

        [Field("USDCURR")]
        [ParameterType(DbType.Decimal)]
        public decimal? UsdCurr { get; set; }

        [Field("EURCURR")]
        [ParameterType(DbType.Decimal)]
        public decimal? EurCurr { get; set; }

        #endregion

    }
}
