using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_ERDR_OFFER_APPROVAL için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_ERDR_OFFER_APPROVAL")]
    public class AdmErdrOfferApproval : BaseModel
    {

        #region Constructor

        public AdmErdrOfferApproval()
        {

        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmErdrOfferApproval_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("OFFERREF")]
        [ParameterType(DbType.Int32)]
        public int? Offerref { get; set; }

        [Field("K1_USER")]
        [ParameterType(DbType.String)]
        public string K1User { get; set; }

        [Field("K2_USER")]
        [ParameterType(DbType.String)]
        public string K2User { get; set; }

        [Field("K3_USER")]
        [ParameterType(DbType.String)]
        public string K3User { get; set; }

        [Field("K4_USER")]
        [ParameterType(DbType.String)]
        public string K4User { get; set; }

        [Field("K5_USER")]
        [ParameterType(DbType.String)]
        public string K5User { get; set; }

        [Field("K6_USER")]
        [ParameterType(DbType.String)]
        public string K6User { get; set; }

        [Field("K1_SEND_DATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? K1SendDate { get; set; }

        [Field("K2_SEND_DATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? K2SendDate { get; set; }

        [Field("K3_SEND_DATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? K3SendDate { get; set; }

        [Field("K4_SEND_DATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? K4SendDate { get; set; }

        [Field("K5_SEND_DATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? K5SendDate { get; set; }

        [Field("K6_SEND_DATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? K6SendDate { get; set; }

        [Field("K1_APPROVAL_DATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? K1ApprovalDate { get; set; }

        [Field("K2_APPROVAL_DATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? K2ApprovalDate { get; set; }

        [Field("K3_APPROVAL_DATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? K3ApprovalDate { get; set; }

        [Field("K4_APPROVAL_DATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? K4ApprovalDate { get; set; }

        [Field("K5_APPROVAL_DATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? K5ApprovalDate { get; set; }

        [Field("K6_APPROVAL_DATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? K6ApprovalDate { get; set; }

        [Field("K1_APPROVAL")]
        [ParameterType(DbType.Int32)]
        public int? K1Approval { get; set; }

        [Field("K2_APPROVAL")]
        [ParameterType(DbType.Int32)]
        public int? K2Approval { get; set; }

        [Field("K3_APPROVAL")]
        [ParameterType(DbType.Int32)]
        public int? K3Approval { get; set; }

        [Field("K4_APPROVAL")]
        [ParameterType(DbType.Int32)]
        public int? K4Approval { get; set; }

        [Field("K5_APPROVAL")]
        [ParameterType(DbType.Int32)]
        public int? K5Approval { get; set; }

        [Field("K6_APPROVAL")]
        [ParameterType(DbType.Int32)]
        public int? K6Approval { get; set; }

        [Field("K1_EXP")]
        [ParameterType(DbType.String)]
        public string K1Exp { get; set; }

        [Field("K2_EXP")]
        [ParameterType(DbType.String)]
        public string K2Exp { get; set; }

        [Field("K3_EXP")]
        [ParameterType(DbType.String)]
        public string K3Exp { get; set; }

        [Field("K4_EXP")]
        [ParameterType(DbType.String)]
        public string K4Exp { get; set; }

        [Field("K5_EXP")]
        [ParameterType(DbType.String)]
        public string K5Exp { get; set; }

        [Field("K6_EXP")]
        [ParameterType(DbType.String)]
        public string K6Exp { get; set; }

        [Field("K1_ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? K1Isactive { get; set; }

        [Field("K2_ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? K2Isactive { get; set; }

        [Field("K3_ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? K3Isactive { get; set; }

        [Field("K4_ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? K4Isactive { get; set; }

        [Field("K5_ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? K5Isactive { get; set; }

        [Field("K6_ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? K6Isactive { get; set; }

        [Field("ISSTOPPED")]
        [ParameterType(DbType.Int32)]
        public int? Isstopped { get; set; }

        #endregion

    }
}
