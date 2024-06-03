using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_WORKCENTER için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_WORKCENTER")]
    public class AdmWorkcenter : BaseModel
    {

        #region Constructor

        public AdmWorkcenter()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmWorkcenter_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("CODE")]
        [ParameterType(DbType.String)]
        public string Code { get; set; }

        [Field("COSTCENTER")]
        [ParameterType(DbType.String)]
        public string Costcenter { get; set; }

        [Field("WORKGROUP")]
        [ParameterType(DbType.Int32)]
        public int? Workgroup { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int? Isactive { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        //SONRADAN EKLENEN KISIM

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



        #endregion

    }
}
