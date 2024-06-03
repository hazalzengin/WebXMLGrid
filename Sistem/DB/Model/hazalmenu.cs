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
    [TableName("menu")]
    public class hazalmenu : BaseModel
    {
        public hazalmenu()
        {

        }

        public hazalmenu(string code, string menuname)
        {
            this.code = code;
            this.menuname = menuname;

        }

        [PK]
        [Field("Id")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("code")]
        [ParameterType(DbType.String)]
        public string code { get; set; }


        [Field("menuname")]
        [ParameterType(DbType.String)]
        public string menuname { get; set; }

    }

}