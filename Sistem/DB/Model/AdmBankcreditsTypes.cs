using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_BANKCREDITS_TYPES için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_BANKCREDITS_TYPES")]
    public class AdmBankcreditsTypes : BaseModel
    {

        #region Constructor

        public AdmBankcreditsTypes()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmBankcreditsTypes_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("CODE")]
        [ParameterType(DbType.String)]
        public string Code { get; set; }

        [Field("NAME")]
        [ParameterType(DbType.String)]
        public string Name { get; set; }

        [Field("USETYPE")]
        [ParameterType(DbType.Int32)]
        public int? Usetype { get; set; }

        [Field("USETYPENAME")]
        [ParameterType(DbType.String)]
        public string Usetypename { get; set; }

        [Field("CREDITTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Credittype { get; set; }

        [Field("CREDITTYPENAME")]
        [ParameterType(DbType.String)]
        public string Credittypename { get; set; }

        [Field("INTERESTTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Interesttype { get; set; }

        [Field("INTERESTTYPENAME")]
        [ParameterType(DbType.String)]
        public string Interesttypename { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
