using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_SALESBUDGET için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_SALESBUDGET")]
    public class AdmSalesbudget : BaseModel
    {

        #region Constructor

        public AdmSalesbudget()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmSalesbudget_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("SALESMANREF")]
        [ParameterType(DbType.Int32)]
        public int Salesmanref { get; set; }

        [Field("SALESMANCODE")]
        [ParameterType(DbType.String)]
        public string Salesmancode { get; set; }

        [Field("CLIENTREF")]
        [ParameterType(DbType.Int32)]
        public int Clientref { get; set; }

        [Field("ITEMREF")]
        [ParameterType(DbType.Int32)]
        public int Itemref { get; set; }

        [Field("FIRMNR")]
        [ParameterType(DbType.String)]
        public string Firmnr { get; set; }

        [Field("YEAR")]
        [ParameterType(DbType.Int32)]
        public int? Year { get; set; }

        [Field("MONTH1")]
        [ParameterType(DbType.Double)]
        public double? Month1 { get; set; }

        [Field("MONTH2")]
        [ParameterType(DbType.Double)]
        public double? Month2 { get; set; }

        [Field("MONTH3")]
        [ParameterType(DbType.Double)]
        public double? Month3 { get; set; }

        [Field("MONTH4")]
        [ParameterType(DbType.Double)]
        public double? Month4 { get; set; }

        [Field("MONTH5")]
        [ParameterType(DbType.Double)]
        public double? Month5 { get; set; }

        [Field("MONTH6")]
        [ParameterType(DbType.Double)]
        public double? Month6 { get; set; }

        [Field("MONTH7")]
        [ParameterType(DbType.Double)]
        public double? Month7 { get; set; }

        [Field("MONTH8")]
        [ParameterType(DbType.Double)]
        public double? Month8 { get; set; }

        [Field("MONTH9")]
        [ParameterType(DbType.Double)]
        public double? Month9 { get; set; }

        [Field("MONTH10")]
        [ParameterType(DbType.Double)]
        public double? Month10 { get; set; }

        [Field("MONTH11")]
        [ParameterType(DbType.Double)]
        public double? Month11 { get; set; }

        [Field("MONTH12")]
        [ParameterType(DbType.Double)]
        public double? Month12 { get; set; }

        [Field("TYPE_")]
        [ParameterType(DbType.Int32)]
        public int? Type_ { get; set; }

        #endregion

    }
}
