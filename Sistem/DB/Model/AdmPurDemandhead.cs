using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_PUR_DEMANDHEAD i�in base class�
    /// </summary>
    [Serializable]
    [TableName("ADM_PUR_DEMANDHEAD")]
    public class AdmPurDemandhead : BaseModel
    {

        #region Constructor

        public AdmPurDemandhead()
        {
        
        }

        #endregion

        #region Tablonun columnlar�

        [PK]
        [Identity("AdmPurDemandhead_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("DATE_")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Date_ { get; set; }

        [Field("DUEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Duedate { get; set; }

        [Field("PERSONNELREF")]
        [ParameterType(DbType.Int32)]
        public int? Personnelref { get; set; }

        [Field("PERSONNELNAME")]
        [ParameterType(DbType.String)]
        public string Personnelname { get; set; }

        [Field("DEPARTMENTREF")]
        [ParameterType(DbType.Int32)]
        public int? Departmentref { get; set; }

        [Field("PRIORITY")]
        [ParameterType(DbType.Int32)]
        public int? Priority { get; set; }

        [Field("DEMANDTYPE")]
        [ParameterType(DbType.Int32)]
        public int? Demandtype { get; set; }

        [Field("PROJECTCODE")]
        [ParameterType(DbType.String)]
        public string Projectcode { get; set; }

        [Field("COSTCENTERREF")]
        [ParameterType(DbType.Int32)]
        public int? Costcenterref { get; set; }

        [Field("COSTCENTERCODE")]
        [ParameterType(DbType.String)]
        public string Costcentercode { get; set; }

        [Field("COSTCENTERNAME")]
        [ParameterType(DbType.String)]
        public string Costcentername { get; set; }

        [Field("EXP")]
        [ParameterType(DbType.String)]
        public string Exp { get; set; }

        [Field("DEMANDSTATUS")]
        [ParameterType(DbType.Int32)]
        public int? Demandstatus { get; set; }

        [Field("APPROVESTATUS")]
        [ParameterType(DbType.Int32)]
        public int? Approvestatus { get; set; }

        [Field("APPROVEDBY")]
        [ParameterType(DbType.String)]
        public string Approvedby { get; set; }

        [Field("APPROVEDATE")]
        [ParameterType(DbType.DateTime)]
        public DateTime? Approvedate { get; set; }

        [Field("TRANSFERSTATUS")]
        [ParameterType(DbType.Int32)]
        public int? Transferstatus { get; set; }

        [Field("TRANSFERMESSAGE")]
        [ParameterType(DbType.String)]
        public string Transfermessage { get; set; }

        [Field("LGREF")]
        [ParameterType(DbType.Int32)]
        public int? Lgref { get; set; }

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

        [Field("ISOFFERCREATED")]
        [ParameterType(DbType.Int32)]
        public int? Isoffercreated { get; set; }

        [Field("ISORDERCREATED")]
        [ParameterType(DbType.Int32)]
        public int? Isordercreated { get; set; }

        #endregion

    }
}
