using kk.Ebank.Mapper;
using Sistem.DB.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sistem.DB.Repo
{
    public class hazaluserrepo : BaseRepository<hazaluser>
    {
        LoginHashing _loginHashing = new LoginHashing();
        public List<hazaluser> GetItemClass(int id)
        {
            var query = new FrQueryBase(dbo);
            query.From("users");

            if (id > -1)
            {
                query.Eq("Id", id);
            }
            //if (isDel > -1)
            //    query.Eq("ISDEL", isDel);
            return query.ToDataSet().ToFrList<hazaluser>();
        }

        public List<hazaluser> GetDataToClass(int id, String kullanici, String sifre)
        {
            var queryBase = new FrQueryBase(this.dbo);
            queryBase.From("users");
            if (id > -1)
                queryBase.Eq("Id", id);
            if (kullanici != null)
                queryBase.Eq("username", kullanici);
            if (sifre != null)
                queryBase.Eq("password", _loginHashing.Encrypt(sifre));

            return queryBase.OrderBy("Id", OrderDirection.Desc).ToDataSet().ToFrList<hazaluser>();
        }
        public List<hazaluser> GetAll()
        {
            var queryBase = new FrQueryBase(this.dbo);
            queryBase.From("users");
            return queryBase.ToDataSet().ToFrList<hazaluser>();
        }

        public DataSet GetAll2(int? id, String kullanici, String sifre)
        {
            var queryBase = new FrQueryBase(this.dbo);
            queryBase.From("users");
            if (id > -1)
                queryBase.Eq("Id", id);
            if (kullanici != null)
                queryBase.Eq("username", kullanici);
            if (sifre != null)
                queryBase.Eq("password", _loginHashing.Encrypt(sifre));

            return queryBase.OrderBy("Id", OrderDirection.Desc).ToDataSet();
        }

    }
}
