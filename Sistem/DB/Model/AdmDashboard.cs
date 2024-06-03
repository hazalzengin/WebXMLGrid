using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_DASHBOARD için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_DASHBOARD")]
    public class AdmDashboard : BaseModel
    {

        #region Constructor

        public AdmDashboard()
        {
        
        }

        public AdmDashboard( string name,  string exp,  int type,  string x,  string y,  string query,  int orderNo,  int isactive)
        {
            this.Name = name;
            this.Exp = exp;
            this.Type = type;
            this.X = x;
            this.Y = y;
            this.Query = query;
            this.OrderNo = orderNo;
            this.Isactive = isactive;

        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmDashboard_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("NAME")]
        [ParameterType(DbType.String)]
        public string Name { get; set; }

        [Field("EXP")]
        [ParameterType(DbType.String)]
        public string Exp { get; set; }

        [Field("TYPE")]
        [ParameterType(DbType.Int32)]
        public int Type { get; set; }

        [Field("X")]
        [ParameterType(DbType.String)]
        public string X { get; set; }

        [Field("Y")]
        [ParameterType(DbType.String)]
        public string Y { get; set; }

        [Field("QUERY")]
        [ParameterType(DbType.String)]
        public string Query { get; set; }

        [Field("ORDER_NO")]
        [ParameterType(DbType.Int32)]
        public int OrderNo { get; set; }

        [Field("FORMAT")]
        [ParameterType(DbType.String)]
        public string Format
        {
            get; set;
        }

        [NoMapping]
        public DataTable Source
        {
            get; set;
        }


        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int Isactive { get; set; }


        #endregion

    }
}
