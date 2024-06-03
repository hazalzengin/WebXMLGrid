using kk.Ebank.DataAccess;
using kk.Ebank.Mapper;
using Sistem.DB.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem.DB.Repo
{
    class hazalusermenurepo : BaseRepository<hazalusermenu>
    {


        public List<hazalusermenu> GetItemClass(int userRef, int menuRef)
        {
            var query = new FrQueryBase(dbo);
            query.From("menu_user");

            if (userRef > -1)
            {
                query.Eq("userref", userRef);
            }
            if (menuRef > -1)
            {
                query.Eq("menuref", menuRef);
            }
            return query.ToDataSet().ToFrList<hazalusermenu>();
        }

        public List<hazalusermenu> GetItemYetki(int userRef)
        {
            var query = new FrQueryBase(dbo);
            query.From("menu_user");

            if (userRef > -1)
            {
                query.Eq("userref", userRef);
            }

            return query.ToDataSet().ToFrList<hazalusermenu>();
        }

        public DataSet GetAll(int? userRef, int? menuRef)
        {
            var query = new FrQueryBase(dbo);
            query.From("menu_user");
            if (userRef > -1)
            {
                query.Eq("userref", userRef);
            }
            if (menuRef > -1)
            {
                query.Eq("menuref", menuRef);
            }
            return query.OrderBy("id", OrderDirection.Desc).ToDataSet();
        }

        public void VerileriSil(int kul)
        {
            var dbObject = String.IsNullOrEmpty(ProgramConnection.ConStr) ? new DbObject(0) : new DbObject(ProgramConnection.ConStr);
            var kParameter = new SqlParameter[1];
            kParameter[0] = new SqlParameter("@kulId", kul);
            dbObject.RunSPNonQuery("sp_MenuYetkiVerileriniSil", kParameter);
        }

    }
}
