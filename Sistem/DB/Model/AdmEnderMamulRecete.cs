using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_ENDER_MAMUL_RECETE için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_ENDER_MAMUL_RECETE")]
    public class AdmEnderMamulRecete : BaseModel
    {

        #region Constructor

        public AdmEnderMamulRecete()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmEnderMamulRecete_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("KODU")]
        [ParameterType(DbType.String)]
        public string Kodu { get; set; }

        [Field("ESKIKODU")]
        [ParameterType(DbType.String)]
        public string Eskikodu { get; set; }

        [Field("TURU")]
        [ParameterType(DbType.String)]
        public string Turu { get; set; }

        [Field("KORUMA_BANDI_DIS_YUZEY")]
        [ParameterType(DbType.Double)]
        public double? KorumaBandiDisYuzey { get; set; }

        [Field("KORUMA_BANDI_IC_YUZEY")]
        [ParameterType(DbType.Double)]
        public double? KorumaBandiIcYuzey { get; set; }

        [Field("TPV_CONTA_KASA")]
        [ParameterType(DbType.Double)]
        public double? TpvContaKasa { get; set; }

        [Field("TPV_CONTA_KANAT")]
        [ParameterType(DbType.Double)]
        public double? TpvContaKanat { get; set; }

        [Field("TPV_CONTA_ARA")]
        [ParameterType(DbType.Double)]
        public double? TpvContaAra { get; set; }

        [Field("SOFT_CONTA")]
        [ParameterType(DbType.Double)]
        public double? SoftConta { get; set; }

        [Field("KOLI_BANDI")]
        [ParameterType(DbType.Double)]
        public double? KoliBandi { get; set; }

        [Field("PAKET_AMBALAJI")]
        [ParameterType(DbType.Double)]
        public double? PaketAmbalaji { get; set; }

        [Field("LAMINASYON_TUTKAL_DIS_YUZEY")]
        [ParameterType(DbType.Double)]
        public double? LaminasyonTutkalDisYuzey { get; set; }

        [Field("LAMINASYON_PRIMERI_DIS_YUZEY")]
        [ParameterType(DbType.Double)]
        public double? LaminasyonPrimeriDisYuzey { get; set; }

        [Field("LAMINASYON_TUTKAL_IC_YUZEY")]
        [ParameterType(DbType.Double)]
        public double? LaminasyonTutkalIcYuzey { get; set; }

        [Field("LAMINASYON_PRIMERI_IC_YUZEY")]
        [ParameterType(DbType.Double)]
        public double? LaminasyonPrimeriIcYuzey { get; set; }

        [Field("LAMINASYON_FOLYO_DIS")]
        [ParameterType(DbType.Double)]
        public double? LaminasyonFolyoDis { get; set; }

        [Field("LAMINASYON_FOLYO_IC")]
        [ParameterType(DbType.Double)]
        public double? LaminasyonFolyoIc { get; set; }

        [Field("LAMINASYON_FOLYO_CIFT")]
        [ParameterType(DbType.Double)]
        public double? LaminasyonFolyoCift { get; set; }

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
