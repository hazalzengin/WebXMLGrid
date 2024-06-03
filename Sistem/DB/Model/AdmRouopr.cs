using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_ROUOPR için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_ROUOPR")]
    public class AdmRouopr : BaseModel
    {

        #region Constructor

        public AdmRouopr()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmRouopr_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("ITEMCODE")]
        [ParameterType(DbType.String)]
        public string Itemcode { get; set; }

        [Field("ITEMNAME")]
        [ParameterType(DbType.String)]
        public string Itemname { get; set; }

        [Field("ITEMREF")]
        [ParameterType(DbType.Int32)]
        public int? Itemref { get; set; }

        [Field("QUNIT")]
        [ParameterType(DbType.String)]
        public string Qunit { get; set; }

        [Field("AMOUNT")]
        [ParameterType(DbType.Decimal)]
        public decimal? Amount { get; set; }

        [Field("ROUCODE")]
        [ParameterType(DbType.String)]
        public string Roucode { get; set; }

        [Field("CODE")]
        [ParameterType(DbType.String)]
        public string Code { get; set; }

        [Field("NAME")]
        [ParameterType(DbType.String)]
        public string Name { get; set; }

        [Field("OPRNUM")]
        [ParameterType(DbType.String)]
        public string Oprnum { get; set; }

        [Field("WORKCENTER")]
        [ParameterType(DbType.Int32)]
        public int? Workcenter { get; set; }

        [Field("SETUPTIME")]
        [ParameterType(DbType.String)]
        public string Setuptime { get; set; }

        [Field("BREAKTIME")]
        [ParameterType(DbType.String)]
        public string Breaktime { get; set; }

        [Field("ACTIVITYTIME")]
        [ParameterType(DbType.String)]
        public string Activitytime { get; set; }

        [Field("LABOURTIME")]
        [ParameterType(DbType.String)]
        public string Labourtime { get; set; }

        [Field("NEXTOPRNUM")]
        [ParameterType(DbType.Int32)]
        public int? Nextoprnum { get; set; }

        [Field("SCRAPPER")]
        [ParameterType(DbType.Decimal)]
        public decimal? Scrapper { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }


        [Field("PRDITEMWH")]
        [ParameterType(DbType.Int32)]
        public int? Prditemwh { get; set; }

        [Field("PRDITEMWHNAME")]
        [ParameterType(DbType.String)]
        public string Prditemwhname { get; set; }

        [Field("PRDITEMSHELF")]
        [ParameterType(DbType.Int32)]
        public int? Prditemshelf { get; set; }

        [Field("PRDITEMSHELFNAME")]
        [ParameterType(DbType.String)]
        public string Prditemshelfname { get; set; }

        [Field("SUPPLYITEMWH")]
        [ParameterType(DbType.Int32)]
        public int? Supplyitemwh { get; set; }

        [Field("SUPPLYITEMWHNAME")]
        [ParameterType(DbType.String)]
        public string Supplyitemwhname { get; set; }

        [Field("SUPPLYITEMSHELF")]
        [ParameterType(DbType.Int32)]
        public int? Supplyitemshelf { get; set; }

        [Field("SUPPLYITEMSHELFNAME")]
        [ParameterType(DbType.String)]
        public string Supplyitemshelfname { get; set; }

        [Field("SACTIVITY")]
        [ParameterType(DbType.Int32)]
        public int? Sactivity { get; set; }

        [Field("SACTIVITYNAME")]
        [ParameterType(DbType.String)]
        public string Sactivityname { get; set; }

        [Field("SCOSTTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Scosttype { get; set; }

        [Field("SISCOST")]
        [ParameterType(DbType.Int32)]
        public int? Siscost { get; set; }

        [Field("STIMEUNIT")]
        [ParameterType(DbType.Int32)]
        public int? Stimeunit { get; set; }

        [Field("MACTIVITY")]
        [ParameterType(DbType.Int32)]
        public int? Mactivity { get; set; }

        [Field("MACTIVITYNAME")]
        [ParameterType(DbType.String)]
        public string Mactivityname { get; set; }

        [Field("MCOSTTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Mcosttype { get; set; }

        [Field("MISCOST")]
        [ParameterType(DbType.Int32)]
        public int? Miscost { get; set; }

        [Field("MTIMEUNIT")]
        [ParameterType(DbType.Int32)]
        public int? Mtimeunit { get; set; }

        [Field("LACTIVITY")]
        [ParameterType(DbType.Int32)]
        public int? Lactivity { get; set; }

        [Field("LACTIVITYNAME")]
        [ParameterType(DbType.String)]
        public string Lactivityname { get; set; }

        [Field("LCOSTTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Lcosttype { get; set; }

        [Field("LISCOST")]
        [ParameterType(DbType.Int32)]
        public int? Liscost { get; set; }

        [Field("LTIMEUNIT")]
        [ParameterType(DbType.Int32)]
        public int? Ltimeunit { get; set; }

        [Field("ISQLTREQ")]
        [ParameterType(DbType.Int32)]
        public int? Isqltreq { get; set; }

        #endregion

    }
}
