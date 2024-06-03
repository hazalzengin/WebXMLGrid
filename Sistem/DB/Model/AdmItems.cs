using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_ITEMS için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_ITEMS")]
    public class AdmItems : BaseModel
    {

        #region Constructor

        public AdmItems()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmItems_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("PARENTREF")]
        [ParameterType(DbType.Int32)]
        public int Parentref { get; set; }

        [Field("CODE")]
        [ParameterType(DbType.String)]
        public string Code { get; set; }

        [Field("NAME")]
        [ParameterType(DbType.String)]
        public string Name { get; set; }

        [Field("NAME2")]
        [ParameterType(DbType.String)]
        public string Name2 { get; set; }

        [Field("NAME3")]
        [ParameterType(DbType.String)]
        public string Name3 { get; set; }

        [Field("NAME4")]
        [ParameterType(DbType.String)]
        public string Name4 { get; set; }

        [Field("SPECODE1")]
        [ParameterType(DbType.String)]
        public string Specode1 { get; set; }

        [Field("SPECODE2")]
        [ParameterType(DbType.String)]
        public string Specode2 { get; set; }

        [Field("SPECODE3")]
        [ParameterType(DbType.String)]
        public string Specode3 { get; set; }

        [Field("SPECODE4")]
        [ParameterType(DbType.String)]
        public string Specode4 { get; set; }

        [Field("SPECODE5")]
        [ParameterType(DbType.String)]
        public string Specode5 { get; set; }

        [Field("PRODUCERCODE")]
        [ParameterType(DbType.String)]
        public string Producercode { get; set; }

        [Field("GROUPCODE")]
        [ParameterType(DbType.String)]
        public string Groupcode { get; set; }

        [Field("AUTHCODE")]
        [ParameterType(DbType.String)]
        public string Authcode { get; set; }

        [Field("UNITCODE")]
        [ParameterType(DbType.String)]
        public string Unitcode { get; set; }

        [Field("DEDUCTIONCODE")]
        [ParameterType(DbType.String)]
        public string DeductionCode { get; set; }

        [Field("VAT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Vat { get; set; }

        [Field("ISTRANSFERRED")]
        [ParameterType(DbType.Int32)]
        public int? Istransferred { get; set; }

        [Field("TRANSFERMESSAGE")]
        [ParameterType(DbType.String)]
        public string Transfermessage { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }


        [Field("UNITREF")]
        [ParameterType(DbType.String)]
        public string UnitRef { get; set; }

        [Field("CAN_DEDUCT")]
        [ParameterType(DbType.Int32)]
        public int? Can_Deduct { get; set; }

        [Field("DEDUCT_CODE")]
        [ParameterType(DbType.String)]
        public string DEDUCT_CODE { get; set; }

        [Field("PURCH_DEDUCT_CODE")]
        [ParameterType(DbType.String)]
        public string PURCH_DEDUCT_CODE { get; set; }

        [Field("SALE_DEDUCTION_PART1")]
        [ParameterType(DbType.String)]
        public string SALE_DEDUCTION_PART1 { get; set; }

        [Field("SALE_DEDUCTION_PART2")]
        [ParameterType(DbType.String)]
        public string SALE_DEDUCTION_PART2 { get; set; }

        [Field("PURCH_DEDUCTION_PART1")]
        [ParameterType(DbType.String)]
        public string PURCH_DEDUCTION_PART1 { get; set; }

        [Field("PURCH_DEDUCTION_PART2")]
        [ParameterType(DbType.String)]
        public string PURCH_DEDUCTION_PART2 { get; set; }
        #endregion

    }
}
