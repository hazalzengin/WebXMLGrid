using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_ENDER_MIKSER_RECETE için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_ENDER_MIKSER_RECETE")]
    public class AdmEnderMikserRecete : BaseModel
    {

        #region Constructor

        public AdmEnderMikserRecete()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmEnderMikserRecete_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("TUR")]
        [ParameterType(DbType.String)]
        public string Tur { get; set; }

        [Field("HAMURKODU")]
        [ParameterType(DbType.String)]
        public string Hamurkodu { get; set; }

        [Field("HAMURRENK")]
        [ParameterType(DbType.String)]
        public string Hamurrenk { get; set; }

        [Field("PVC")]
        [ParameterType(DbType.Double)]
        public double? Pvc { get; set; }

        [Field("ACR")]
        [ParameterType(DbType.Double)]
        public double? Acr { get; set; }

        [Field("CPE")]
        [ParameterType(DbType.Double)]
        public double? Cpe { get; set; }

        [Field("STABILIZATOR")]
        [ParameterType(DbType.Double)]
        public double? Stabilizator { get; set; }

        [Field("KALSIT")]
        [ParameterType(DbType.Double)]
        public double? Kalsit { get; set; }

        [Field("TITAN")]
        [ParameterType(DbType.Double)]
        public double? Titan { get; set; }

        [Field("PIGMENT_KOYU_ZEMIN")]
        [ParameterType(DbType.Double)]
        public double? PigmentKoyuZemin { get; set; }

        [Field("PIGMENT_ANTRASIT")]
        [ParameterType(DbType.Double)]
        public double? PigmentAntrasit { get; set; }

        [Field("PIGMENT_BEJ")]
        [ParameterType(DbType.Double)]
        public double? PigmentBej { get; set; }

        [Field("PIGMENT_AFRIKA")]
        [ParameterType(DbType.Double)]
        public double? PigmentAfrika { get; set; }

        [Field("CREATEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Createdate { get; set; }

        [Field("CREATEDBY")]
        [ParameterType(DbType.String)]
        public string Createdby { get; set; }

        [Field("UPDATEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Updatedate { get; set; }

        [Field("UPDATEDBY")]
        [ParameterType(DbType.String)]
        public string Updatedby { get; set; }

        [Field("DELETEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Deletedate { get; set; }

        [Field("DELETEDBY")]
        [ParameterType(DbType.String)]
        public string Deletedby { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
