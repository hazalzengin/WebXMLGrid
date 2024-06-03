using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_PRDCONF için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_PRDCONF")]
    public class AdmPrdconf
    {

        #region Constructor

        public AdmPrdconf()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmPrdconf_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Date_ { get; set; }

        [Field("STARTDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Startdate { get; set; }

        [Field("ENDDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Enddate { get; set; }

        [Field("ORDERREF")]
        [ParameterType(DbType.Int32)]
        public int? Orderref { get; set; }

        [Field("OPRREF")]
        [ParameterType(DbType.Int32)]
        public int? Oprref { get; set; }

        [Field("WAREHOUSE")]
        [ParameterType(DbType.String)]
        public string Warehouse { get; set; }

        [Field("PRODUCED")]
        [ParameterType(DbType.Decimal)]
        public decimal? Produced { get; set; }

        [Field("SCRAP")]
        [ParameterType(DbType.Decimal)]
        public decimal? Scrap { get; set; }

        [Field("WORKCENTER")]
        [ParameterType(DbType.Int32)]
        public int? Workcenter { get; set; }

        [Field("SHIFTREF")]
        [ParameterType(DbType.Int32)]
        public int? Shiftref { get; set; }

        [Field("PERSONELREF")]
        [ParameterType(DbType.Int32)]
        public int? Personelref { get; set; }

        [Field("EXP")]
        [ParameterType(DbType.String)]
        public string Exp { get; set; }

        [Field("SETUPTIME")]
        [ParameterType(DbType.String)]
        public string Setuptime { get; set; }

        [Field("BREAKTIME")]
        [ParameterType(DbType.String)]
        public string Breaktime { get; set; }

        [Field("MACHINETIME")]
        [ParameterType(DbType.String)]
        public string Machinetime { get; set; }

        [Field("LABOURTIME")]
        [ParameterType(DbType.String)]
        public string Labourtime { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        [Field("TRANSFERSTATUS")]
        [ParameterType(DbType.Int32)]
        public int? Transferstatus { get; set; }

        [Field("TRANSFERMESSAGE")]
        [ParameterType(DbType.String)]
        public string Transfermessage { get; set; }

        [Field("LOTNUM")]
        [ParameterType(DbType.String)]
        public string Lotnum { get; set; }

        [Field("LOTSKT")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Lotskt { get; set; }

        [Field("ITEMREF")]
        [ParameterType(DbType.Int32)]
        public int? Itemref { get; set; }

        [Field("ITEMCODE")]
        [ParameterType(DbType.String)]
        public string Itemcode { get; set; }

        [Field("ITEMNAME")]
        [ParameterType(DbType.String)]
        public string Itemname { get; set; }

        [Field("CONFIRMNO")]
        [ParameterType(DbType.Int32)]
        public int? Confirmno { get; set; }

        [Field("CONFIRMSTATUS")]
        [ParameterType(DbType.Int32)]
        public int? Confirmstatus { get; set; }

        #endregion

    }
}
