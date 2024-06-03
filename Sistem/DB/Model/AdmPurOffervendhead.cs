using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_PUR_OFFERVENDHEAD için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_PUR_OFFERVENDHEAD")]
    public class AdmPurOffervendhead : BaseModel
    {

        #region Constructor

        public AdmPurOffervendhead()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmPurOffervendhead_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Date_ { get; set; }

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

        [Field("DELIVERTYPE")]
        [ParameterType(DbType.String)]
        public string Delivertype { get; set; }

        [Field("PAYMENTTYPE")]
        [ParameterType(DbType.String)]
        public string Paymenttype { get; set; }

        [Field("CONTACT")]
        [ParameterType(DbType.String)]
        public string Contact { get; set; }

        [Field("MAIL")]
        [ParameterType(DbType.String)]
        public string Mail { get; set; }

        [Field("PHONE")]
        [ParameterType(DbType.String)]
        public string Phone { get; set; }

        [Field("CITY")]
        [ParameterType(DbType.String)]
        public string City { get; set; }

        [Field("EXP")]
        [ParameterType(DbType.String)]
        public string Exp { get; set; }

        [Field("CLIENTAPPROVESTATUS")]
        [ParameterType(DbType.Int32)]
        public int? Clientapprovestatus { get; set; }

        [Field("STARTDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Startdate { get; set; }

        [Field("ENDDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Enddate { get; set; }

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
