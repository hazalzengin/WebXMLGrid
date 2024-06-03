using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_PRD_STOPS için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_PRD_STOPS")]
    public class AdmPrdStops : BaseModel
    {

        #region Constructor

        public AdmPrdStops()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmPrdStops_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("STOPCODEREF")]
        [ParameterType(DbType.Int32)]
        public int Stopcoderef { get; set; }

        [Field("PRODREF")]
        [ParameterType(DbType.Int32)]
        public int? Prodref { get; set; }

        [Field("PRODACCEPTREF")]
        [ParameterType(DbType.Int32)]
        public int? Prodacceptref { get; set; }

        [Field("STOPTIME")]
        [ParameterType(DbType.String)]
        public string Stoptime { get; set; }

        [Field("PERSONNELREF")]
        [ParameterType(DbType.Int32)]
        public int? Personnelref { get; set; }

        [Field("PERSONNELNAME")]
        [ParameterType(DbType.String)]
        public string Personnelname { get; set; }

        [Field("EXP")]
        [ParameterType(DbType.String)]
        public string Exp { get; set; }

        #endregion

    }
}
