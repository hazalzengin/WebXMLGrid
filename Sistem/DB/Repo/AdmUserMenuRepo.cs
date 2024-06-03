using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
using kk.Ebank.DataAccess;
using System.Data.SqlClient;

namespace Sistem.DB.Repo
{
    public class AdmUserMenuRepo:BaseRepository<AdmUserMenu> 
    {

        public List<AdmUserMenu> GetItemClass(int userRef, int menuRef)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_USER_MENU");

            if (userRef > -1)
            {
                query.Eq("USERREF", userRef);
            }
            if (menuRef > -1)
            {
                query.Eq("MENUREF", menuRef);
            }
            return query.ToDataSet().ToFrList<AdmUserMenu>();
        }

        public DataSet GetAll(int userRef, int menuRef)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_USER_MENU");
            if (userRef > -1)
            {
                query.Eq("USERREF", userRef);
            }
            if (menuRef > -1)
            {
                query.Eq("MENUREF", menuRef);
            }
            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
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
