using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_ICMAL için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_ICMAL")]
    public class AdmIcmal : BaseModel
    {

        #region Constructor

        public AdmIcmal()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmIcmal_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("DATE_")]  
        [ParameterType(DbType.DateTime)]
        public DateTime? Date_ { get; set; }

        [Field("WHCODE")]
        [ParameterType(DbType.String)]
        public string Whcode { get; set; }

        [Field("WHNAME")]
        [ParameterType(DbType.String)]
        public string Whname { get; set; }

        [Field("CLNAME")]
        [ParameterType(DbType.String)]
        public string Clname { get; set; }

        [Field("TCNO")]
        [ParameterType(DbType.String)]
        public string Tcno { get; set; }

        [Field("VKN")]
        [ParameterType(DbType.String)]
        public string Vkn { get; set; }

        [Field("ITEMCODE")]
        [ParameterType(DbType.String)]
        public string Itemcode { get; set; }

        [Field("ITEMNAME")]
        [ParameterType(DbType.String)]
        public string Itemname { get; set; }

        [Field("AMOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Amount { get; set; }

        [Field("FIRMAMF")]
        [ParameterType(DbType.Decimal)]
        public decimal? Firmamf { get; set; }

        [Field("DEPOMF")]
        [ParameterType(DbType.Decimal)]
        public decimal? Depomf { get; set; }

        [Field("TOTAL")]
        [ParameterType(DbType.Decimal)]
        public decimal? Total { get; set; }

        [Field("PROVINCE")]
        [ParameterType(DbType.String)]
        public string Province { get; set; }

        [Field("DISTRICT")]
        [ParameterType(DbType.String)]
        public string District { get; set; }

        #endregion

    }
}
