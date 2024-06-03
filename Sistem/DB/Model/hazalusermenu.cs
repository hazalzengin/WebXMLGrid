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
    [TableName("menu_user")]
    public class hazalusermenu : BaseModel
    {
        public hazalusermenu()
        {

        }
        public hazalusermenu(int userref, int menuref)
        {
            this.Userref = userref;
            this.Menuref = menuref;

        }
        [Identity("hazalusermenu_seq")]
        [PK]
        [Field("id")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("userref")]
        [ParameterType(DbType.Int32)]
        public int Userref { get; set; }

        [Field("menuref")]
        [ParameterType(DbType.Int32)]
        public int Menuref { get; set; }


    }
}

