using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_ENDER_URETIMMIKTAR için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_ENDER_URETIMMIKTAR")]
    public class AdmEnderUretimmiktar : BaseModel
    {

        #region Constructor

        public AdmEnderUretimmiktar()
        {

        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmEnderUretimmiktar_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("YEAR_")]
        [ParameterType(DbType.Int32)]
        public int? Year_ { get; set; }

        [Field("MONTH_")]
        [ParameterType(DbType.Int32)]
        public int? Month_ { get; set; }

        [Field("MONTH_TEXT")]
        [ParameterType(DbType.String)]
        public string MonthText { get; set; }

        [Field("URETIM_MIKTAR_KG")]
        [ParameterType(DbType.Double)]
        public double? UretimMiktarKg { get; set; }

        [Field("URETIM_MIKTAR_LAMINE_KG")]
        [ParameterType(DbType.Double)]
        public double? UretimMiktarLamineKg { get; set; }

        [Field("URETIM_MIKTAR_M2")]
        [ParameterType(DbType.Double)]
        public double? UretimMiktarM2 { get; set; }

        [Field("URETIM_MIKTAR_LAMINE_M2")]
        [ParameterType(DbType.Double)]
        public double? UretimMiktarLamineM2 { get; set; }

        #endregion

    }
}
