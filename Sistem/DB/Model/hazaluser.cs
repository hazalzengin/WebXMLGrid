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
    [TableName("users")]
    public class hazaluser : BaseModel
    {
        public hazaluser()
        {

        }

        public hazaluser(string username, string password, string email)
        {
            this.username = username;
            this.password = password;
            this.email = email;


        }
        [Identity("hazaluser_seq")]
        [PK]
        [Field("Id")]
        [ParameterType(DbType.Int32)]
        public int Id { get; set; }

        [Field("username")]
        [ParameterType(DbType.String)]
        public string username { get; set; }


        [Field("email")]
        [ParameterType(DbType.String)]
        public string email { get; set; }

        [Field("password")]
        [ParameterType(DbType.String)]
        public string password { get; set; }


    }
}
