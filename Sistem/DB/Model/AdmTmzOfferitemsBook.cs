using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_TMZ_OFFERITEMS_BOOK için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_TMZ_OFFERITEMS_BOOK")]
    public class AdmTmzOfferitemsBook : BaseModel
    {

        #region Constructor

        public AdmTmzOfferitemsBook()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmTmzOfferitemsBook_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("OFFERREF")]
        [ParameterType(DbType.Int32)]
        public int? Offerref { get; set; }

        [Field("OFFERITEMREF")]
        [ParameterType(DbType.Int32)]
        public int? Offeritemref { get; set; }

        [Field("NAME")]
        [ParameterType(DbType.String)]
        public string Name { get; set; }

        [Field("PAGESIZE")]
        [ParameterType(DbType.Int32)]
        public int? Pagesize { get; set; }

        [Field("EXP")]
        [ParameterType(DbType.String)]
        public string Exp { get; set; }

        [Field("CREATEDBY")]
        [ParameterType(DbType.String)]
        public string Createdby { get; set; }

        [Field("CREATEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Createdate { get; set; }

        [Field("UPDATEDBY")]
        [ParameterType(DbType.String)]
        public string Updatedby { get; set; }

        [Field("UPDATEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Updatedate { get; set; }

        [Field("DELETEDBY")]
        [ParameterType(DbType.String)]
        public string Deletedby { get; set; }

        [Field("DELETEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Deletedate { get; set; }

        [Field("ISDEL")]
        [ParameterType(DbType.Int32)]
        public int? Isdel { get; set; }

        #endregion

    }
}
