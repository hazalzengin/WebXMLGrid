using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_SYS_REPORTHEAD için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_SYS_REPORTHEAD")]
    public class AdmSysReporthead : BaseModel
    {

        #region Constructor

        public AdmSysReporthead()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmSysReporthead_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("REPORTCODE")]
        [ParameterType(DbType.String)]
        public string Reportcode { get; set; }

        [Field("REPORTNAME")]
        [ParameterType(DbType.String)]
        public string Reportname { get; set; }

        [Field("SELECTC")]
        [ParameterType(DbType.String)]
        public string Selectc { get; set; }

        [Field("FROMC")]
        [ParameterType(DbType.String)]
        public string Fromc { get; set; }

        [Field("WHEREC")]
        [ParameterType(DbType.String)]
        public string Wherec { get; set; }

        [Field("GROUPC")]
        [ParameterType(DbType.String)]
        public string Groupc { get; set; }

        [Field("ORDERC")]
        [ParameterType(DbType.String)]
        public string Orderc { get; set; }

        [Field("HAVINGC")]
        [ParameterType(DbType.String)]
        public string Havingc { get; set; }

        [Field("HASDATEFILTER")]
        [ParameterType(DbType.Int32)]
        public int? Hasdatefilter { get; set; }

        [Field("DATEFIELD")]
        [ParameterType(DbType.String)]
        public string Datefield { get; set; }

        [Field("HASCLFILTER")]
        [ParameterType(DbType.Int32)]
        public int? Hasclfilter { get; set; }

        [Field("CLFILTERTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Clfiltertype { get; set; }

        [Field("CLFIELD")]
        [ParameterType(DbType.String)]
        public string Clfield { get; set; }

        [Field("HASITEMFILTER")]
        [ParameterType(DbType.Int32)]
        public int? Hasitemfilter { get; set; }

        [Field("ITEMFILTERTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Itemfiltertype { get; set; }

        [Field("ITEMFIELD")]
        [ParameterType(DbType.String)]
        public string Itemfield { get; set; }

        [Field("HASWHFILTER")]
        [ParameterType(DbType.Int32)]
        public int? Haswhfilter { get; set; }

        [Field("WHFILTERTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Whfiltertype { get; set; }

        [Field("WHFIELD")]
        [ParameterType(DbType.String)]
        public string Whfield { get; set; }

        [Field("HASSALESMANFILTER")]
        [ParameterType(DbType.Int32)]
        public int? Hassalesmanfilter { get; set; }

        [Field("SALESMANFILTERTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Salesmanfiltertype { get; set; }

        [Field("SALESMANFIELD")]
        [ParameterType(DbType.String)]
        public string Salesmanfield { get; set; }

        [Field("HASBRANCHFILTER")]
        [ParameterType(DbType.Int32)]
        public int? Hasbranchfilter { get; set; }

        [Field("BRANCHFILTERTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Branchfiltertype { get; set; }

        [Field("BRNCHFIELD")]
        [ParameterType(DbType.String)]
        public string Brnchfield { get; set; }

        [Field("KEYFIELDNAME")]
        [ParameterType(DbType.String)]
        public string Keyfieldname { get; set; }

        #endregion

    }
}
