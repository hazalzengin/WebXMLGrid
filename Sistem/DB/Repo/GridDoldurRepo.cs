using kk.Ebank.Mapper;
using Sistem.DB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem.DB.Repo
{
    class GridDoldurRepo: BaseRepository<GridDoldur>
    {
        LoginHashing _loginHashing = new LoginHashing();
        public List<GridDoldur> GetItemClass(int id)
        {
            var query = new FrQueryBase(dbo);
            query.From("GridDoldur");

            if (id > -1)
            {
                query.Eq("Id", id);
            }
            //if (isDel > -1)
            //    query.Eq("ISDEL", isDel);
            return query.ToDataSet().ToFrList<GridDoldur>();
        }

        public List<GridDoldur> GetDataToClass(int id, String kullanici, String sifre)
        {
            var queryBase = new FrQueryBase(this.dbo);
            queryBase.From("GridDoldur");
            if (id > -1)
                queryBase.Eq("Id", id);
            if (kullanici != null)
                queryBase.Eq("UserId", kullanici);
            if (kullanici != null)
                queryBase.Eq("ColumnName", kullanici);
            if (kullanici != null)
                queryBase.Eq("Width", kullanici);
            if (sifre != null)
                queryBase.Eq("VisibleIndex", kullanici);

            return queryBase.OrderBy("Id", OrderDirection.Desc).ToDataSet().ToFrList<GridDoldur>();
        }
        public List<GridDoldur> GetAll()
        {
            var queryBase = new FrQueryBase(this.dbo);
            queryBase.From("GridDoldur");
            return queryBase.ToDataSet().ToFrList<GridDoldur>();
        }
    
    }
}
