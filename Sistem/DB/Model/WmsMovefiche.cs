using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// WMS_MOVEFICHE için base classý
    /// </summary>
    [Serializable]
    [TableName("WMS_MOVEFICHE")]
    public class WmsMovefiche : BaseModel
    {

        #region Constructor

        public WmsMovefiche()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("WmsMovefiche_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Date_ { get; set; }

        [Field("FICHENO")]
        [ParameterType(DbType.String)]
        public string Ficheno { get; set; }

        [Field("TRCODE")]
        [ParameterType(DbType.Int32)]
        public int? Trcode { get; set; }

        [Field("SALESTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Salestype { get; set; }

        [Field("PURCHASETYPE")]
        [ParameterType(DbType.Int32)]
        public int? Purchasetype { get; set; }

        [Field("CLIENTREF")]
        [ParameterType(DbType.Int32)]
        public int? Clientref { get; set; }

        [Field("CLCODE")]
        [ParameterType(DbType.String)]
        public string Clcode { get; set; }

        [Field("CLNAME")]
        [ParameterType(DbType.String)]
        public string Clname { get; set; }

        [Field("WMSREF")]
        [ParameterType(DbType.Int32)]
        public int? WmsRef { get; set; }

        [Field("ISDELETE")]
        [ParameterType(DbType.Int32)]
        public int? Isdelete { get; set; }

        [Field("ISTRANSFERRED")]
        [ParameterType(DbType.Int32)]
        public int? Istransferred { get; set; }

        [Field("LFICHEREF")]
        [ParameterType(DbType.Int32)]
        public int? Lficheref { get; set; }

        [Field("NTFKEY")]
        [ParameterType(DbType.String)]
        public string Ntfkey { get; set; }

        [Field("CREATEDAT")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Createdat { get; set; }

        [Field("CREATEDBY")]
        [ParameterType(DbType.String)]
        public string Createdby { get; set; }

        [Field("CHANGEDAT")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Changedat { get; set; }

        [Field("CHANGEDBY")]
        [ParameterType(DbType.String)]
        public string Changedby { get; set; }

        #endregion

    }
}
