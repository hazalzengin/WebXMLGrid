using kk.Ebank.Mapper.Attributes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem.DB.Model
{
        [Serializable]
        [TableName("GridDoldur")]

        public class GridDoldur: BaseModel
        {

            [Identity("GridDoldur_seq")]
            [PK]
            [Field("Id")]
            [ParameterType(DbType.Int32)]
            public int Id { get; set; }

            [PK]
            [Field("UserId")]
            [ParameterType(DbType.Int32)]
            public int UserId { get; set; }
            [Field("ColumnName")]
            [ParameterType(DbType.String)]
            public string ColumnName { get; set; }

            [Field("Width")]
            [ParameterType(DbType.String)]
            public string Width { get; set; }
            [Field("VisibleIndex")]
            [ParameterType(DbType.String)]
            public int VisibleIndex { get; set; }
        }
    
}
