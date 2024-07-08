using kk.Ebank.Mapper;
using Sistem.DB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem.DB.Repo
{
    public class eventsrepo : BaseRepository<events>
    {
        LoginHashing _loginHashing = new LoginHashing();
        //public List<hazaluser> GetItemClass()
        //{
        //    var query = new FrQueryBase(dbo);
        //    query.From("events");

        //    return query.ToDataSet().ToFrList<events>();
        //}

        public List<hazaluser> GetDataToClass(DateTime startdate, DateTime enddate, String events)
        {
            var queryBase = new FrQueryBase(this.dbo);
            queryBase.From("events");
            if (startdate!= null)
                queryBase.Eq("startdate", startdate);
            if (enddate != null)
                queryBase.Eq("enddate", enddate);
            if (events != null)
                queryBase.Eq("events", (events));

            return queryBase.Select("Id").ToDataSet().ToFrList<hazaluser>();
        }
        public List<events> GetAll()
        {
            var queryBase = new FrQueryBase(this.dbo);
            queryBase.From("events");
            return queryBase.ToDataSet().ToFrList<events>();
        }

       

    }
}
