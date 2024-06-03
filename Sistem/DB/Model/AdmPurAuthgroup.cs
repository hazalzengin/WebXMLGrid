using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_PUR_AUTHGROUP için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_PUR_AUTHGROUP")]
    public class AdmPurAuthgroup : BaseModel
    {

        #region Constructor

        public AdmPurAuthgroup()
        {
        
        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmPurAuthgroup_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("GROUPCODE")]
        [ParameterType(DbType.String)]
        public string Groupcode { get; set; }

        [Field("GROUPNAME")]
        [ParameterType(DbType.String)]
        public string Groupname { get; set; }



        #endregion

    }
}
