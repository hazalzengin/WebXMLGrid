using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// AMD_WORKCENTER_PERSON i�in base class�
    /// </summary>
    [Serializable]
    [TableName("ADM_WORKCENTER_PERSON")]
    public class AdmWorkcenterPerson
    {

        #region Constructor

        public AdmWorkcenterPerson()
        {
        
        }

        #endregion

        #region Tablonun columnlar�

        [PK]
        [Identity("AdmWorkcenterPerson_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("WORKCENTERREF")]
        [ParameterType(DbType.Int32)]
        public int? Workcenterref { get; set; }

        [Field("USERREF")]
        [ParameterType(DbType.Int32)]
        public int? Userref { get; set; }

        [Field("HASMAINPERSON")]
        [ParameterType(DbType.Int32)]
        public int? Hasmainperson { get; set; }

        #endregion

    }
}
