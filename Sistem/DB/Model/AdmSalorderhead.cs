using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_SALORDERHEAD için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_SALORDERHEAD")]
    public class AdmSalorderhead : BaseModel
    {

        #region Constructor

        public AdmSalorderhead()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmSalorderhead_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("FICHENO")]
        [ParameterType(DbType.String)]
        public string Ficheno { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.Date)]
        public DateTime Date_ { get; set; }

        [Field("CLCODE")]
        [ParameterType(DbType.String)]
        public string Clcode { get; set; }

        [Field("CLNAME")]
        [ParameterType(DbType.String)]
        public string Clname { get; set; }

        [Field("ADDRESS")]
        [ParameterType(DbType.String)]
        public string Address { get; set; }

        [Field("DELIVERYADDRESS")]
        [ParameterType(DbType.String)]
        public string Deliveryaddress { get; set; }

        [Field("RELATEDPERSON")]
        [ParameterType(DbType.String)]
        public string Relatedperson { get; set; }

        [Field("TELNUMBER")]
        [ParameterType(DbType.String)]
        public string Telnumber { get; set; }

        [Field("EMAIL")]
        [ParameterType(DbType.String)]
        public string Email { get; set; }

        [Field("ISCOMPLETED")]
        [ParameterType(DbType.Int32)]
        public int? Iscompleted { get; set; }

        [Field("CREATEDAT")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Createdat { get; set; }

        [Field("CREATEDBY")]
        [ParameterType(DbType.String)]
        public string Createdby { get; set; }

        [Field("CHANGEDAT")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Changedat { get; set; }

        [Field("CHANGEDBY")]
        [ParameterType(DbType.String)]
        public string Changedby { get; set; }

        [Field("NOTE1")]
        [ParameterType(DbType.String)]
        public string Note1 { get; set; }

        [Field("NOTE2")]
        [ParameterType(DbType.String)]
        public string Note2 { get; set; }

        [Field("NOTE3")]
        [ParameterType(DbType.String)]
        public string Note3 { get; set; }

        [Field("NOTE4")]
        [ParameterType(DbType.String)]
        public string Note4 { get; set; }

        [Field("NOTE5")]
        [ParameterType(DbType.String)]
        public string Note5 { get; set; }

        [Field("CURRENCY")]
        [ParameterType(DbType.String)]
        public string Currency { get; set; }

        [Field("GROSS")]
        [ParameterType(DbType.Decimal)]
        public decimal? Gross { get; set; }

        [Field("VATTOTAL")]
        [ParameterType(DbType.Decimal)]
        public decimal? Vattotal { get; set; }

        [Field("NETTOTAL")]
        [ParameterType(DbType.Decimal)]
        public decimal? Nettotal { get; set; }

        [Field("PAYMENTCODE")]
        [ParameterType(DbType.String)]
        public string Paymentcode { get; set; }

        [Field("PAYMENTTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Paymenttype { get; set; }

        #endregion

    }
}
