using kk.Ebank.Mapper;
using Sistem.DB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem.DB.Repo
{
    class hazalmenurepo : BaseRepository<hazalmenu>
    {

        LoginHashing _loginHashing = new LoginHashing();
        public List<hazalmenu> GetItemClass(int id)
        {
            var query = new FrQueryBase(dbo);
            query.From("users");

            if (id > -1)
            {
                query.Eq("Id", id);
            }
            //if (isDel > -1)
            //    query.Eq("ISDEL", isDel);
            return query.ToDataSet().ToFrList<hazalmenu>();
        }

        public List<hazalmenu> GetDataToClass(int? id, String code, String menuname)
        {
            var queryBase = new FrQueryBase(this.dbo);
            queryBase.From("menu");
            if (id > -1)
                queryBase.Eq("Id", id);
            if (code != null)
                queryBase.Eq("menuname", code);
            if (menuname != null)
                queryBase.Eq("password", menuname);

            return queryBase.OrderBy("Id", OrderDirection.Asc).ToDataSet().ToFrList<hazalmenu>();
        }

    }
}
