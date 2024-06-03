using System;
using System.Data;
using kk.Ebank.Mapper.Attributes;

namespace Sistem.DB.Model
{
    /// <summary>
    /// ADM_DASHSUM için base classý
    /// </summary>
    [Serializable]
    [TableName("ADM_DASHSUM")]
    public class AdmDashsum : BaseModel
    {

        #region Constructor

        public AdmDashsum()
        {
        
        }

        public AdmDashsum( string name,  string exp,  string link,  string icon,  string color,  string color2,  string query,  int orderNo,  int isactive)
        {
            this.Name = name;
            this.Exp = exp;
            this.Link = link;
            this.Icon = icon;
            this.Color = color;
            this.Color2 = color2;
            this.Query = query;
            this.OrderNo = orderNo;
            this.Isactive = isactive;

        }

        #endregion

        #region Tablonun columnlarý

        [PK]
        [Identity("AdmDashsum_seq")]
        [Field("ID")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("NAME")]
        [ParameterType(DbType.String)]
        public string Name { get; set; }

        [Field("EXP")]
        [ParameterType(DbType.String)]
        public string Exp { get; set; }

        [Field("LINK")]
        [ParameterType(DbType.String)]
        public string Link { get; set; }

        [Field("ICON")]
        [ParameterType(DbType.String)]
        public string Icon { get; set; }

        [Field("COLOR")]
        [ParameterType(DbType.String)]
        public string Color { get; set; }

        [Field("COLOR2")]
        [ParameterType(DbType.String)]
        public string Color2 { get; set; }

        [Field("QUERY")]
        [ParameterType(DbType.String)]
        public string Query { get; set; }

        [Field("ORDER_NO")]
        [ParameterType(DbType.Int32)]
        public int OrderNo { get; set; }

        [Field("FORMAT")]
        [ParameterType(DbType.String)]
        public string Format { get; set; }

        [Field("ISACTIVE")]
        [ParameterType(DbType.Int32)]
        public int Isactive { get; set; }

        [NoMapping]
        [Field("USERREF")]
        [ParameterType(DbType.Int32)]
        public int Userref { get; set; }

        #endregion

    }
}
