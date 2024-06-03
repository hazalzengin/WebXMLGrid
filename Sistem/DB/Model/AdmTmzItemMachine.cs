using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_TMZ_ITEM_MACHINE için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_TMZ_ITEM_MACHINE")]
    public class AdmTmzItemMachine : BaseModel
    {

        #region Constructor

        public AdmTmzItemMachine()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmTmzItemMachine_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("ITEMCODE")]
        [ParameterType(DbType.String)]
        public string Itemcode { get; set; }

        [Field("ITEMNAME")]
        [ParameterType(DbType.String)]
        public string Itemname { get; set; }

        [Field("IC_MAKINEREF")]
        [ParameterType(DbType.Int32)]
        public int? IcMakineref { get; set; }

        [Field("IC_MAKINE_CODE")]
        [ParameterType(DbType.String)]
        public string IcMakineCode { get; set; }

        [Field("ARTIK_MAKINEREF")]
        [ParameterType(DbType.Int32)]
        public int? ArtikMakineref { get; set; }

        [Field("ARTIK_MAKINE_CODE")]
        [ParameterType(DbType.String)]
        public string ArtikMakineCode { get; set; }

        [Field("ARTIK_TABAKADA_ADET")]
        [ParameterType(DbType.Int32)]
        public int? ArtikTabakadaAdet { get; set; }

        [Field("ARTIK_KALIP_SAYISI")]
        [ParameterType(DbType.Int32)]
        public int? ArtikKalipSayisi { get; set; }

        [Field("FORMA_SAYISI")]
        [ParameterType(DbType.String)]
        public string FormaSayisi { get; set; }

        [Field("ARTIK_SAYISI")]
        [ParameterType(DbType.Int32)]
        public int? ArtikSayisi { get; set; }

        [Field("IC_TABAKADA_ADET")]
        [ParameterType(DbType.Int32)]
        public int? IcTabakadaAdet { get; set; }

        [Field("KAPAK_MAKINEREF")]
        [ParameterType(DbType.Int32)]
        public int? KapakMakineref { get; set; }

        [Field("KAPAK_MAKINE_CODE")]
        [ParameterType(DbType.String)]
        public string KapakMakineCode { get; set; }

        [Field("KAPAK_TABAKADA_ADET")]
        [ParameterType(DbType.Int32)]
        public int? KapakTabakadaAdet { get; set; }

        [Field("EXP1")]
        [ParameterType(DbType.String)]
        public string Exp1 { get; set; }


        [Field("IC_TABAKA_EBAT")]
        [ParameterType(DbType.String)]
        public string IcTabakaEbat { get; set; }


        [Field("KAPAK_TABAKA_EBAT")]
        [ParameterType(DbType.String)]
        public string KapakTabakaEbat { get; set; }


        [Field("ARTIK_TABAKA_EBAT")]
        [ParameterType(DbType.String)]
        public string ArtikTabakaEbat { get; set; }

        #endregion

    }
}
