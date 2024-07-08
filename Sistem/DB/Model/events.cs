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
    [TableName("events")]
    public class events : BaseModel
    {
        public events()
        {

        }
            public events(DateTime startday, DateTime enddate, string events)
            {
                this.startday = startday.ToLongDateString();
                this.enddate = enddate.ToLongDateString();
                this.Events = events;


            }
            [Identity("events_seq")]
            [PK]
            [Field("id")]
            [ParameterType(DbType.Int32)]
            public int Id { get; set; }

            [Field("startday")]
            [ParameterType(DbType.DateTime)]
            public string startday { get; set; }


            [Field("enddate")]
            [ParameterType(DbType.DateTime)]
            public string enddate { get; set; }

            [Field("events")]
            [ParameterType(DbType.String)]
            public string Events { get; set; }

        
        }
    }
