using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmMenuRepo : BaseRepository<AdmMenu>
    {

        public List<AdmMenu> GetItemClass(int id)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_MENU");

            if (id > -1)
            {
                query.Eq("ID", id);
            }
            return query.ToDataSet().ToFrList<AdmMenu>();
        }

        public DataSet GetAll(string LANGU,string PARENTREF, int isActive)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_MENU");

            if (!string.IsNullOrWhiteSpace(PARENTREF))
                query.Eq("PARENTREF", PARENTREF);

            if (!string.IsNullOrWhiteSpace(LANGU))
                query.Eq("LANGU", LANGU);

            if (isActive > -1)
            {
                query.Eq("ISACTIVE", isActive);
            }
            return query.OrderBy("ORDERNO", OrderDirection.Asc).ToDataSet();
        }



        public DataSet GetAnaMenu()
        {
            var queryBase = new FrQueryBase(this.dbo);
            return queryBase.From("MENU").Eq("DERINLIK", 1).Eq("GORUNURLUK", 1).OrderBy("SIRA", OrderDirection.Asc).ToDataSet();
        }

        public DataSet GetAltMenu(int id)
        {
            var queryBase = new FrQueryBase(this.dbo);
            return queryBase.From("MENU").Eq("DERINLIK", id).Eq("GORUNURLUK", 1).OrderBy("SIRA", OrderDirection.Asc).ToDataSet();
        }

        public DataSet GetAnaMenuPer(int kulId)
        {
            var queryBase = new FrQueryBase(this.dbo);
            return queryBase.From("VIEW_KULLANICIMENU").Eq("DERINLIK", 1).Eq("KULLANICI_ID", kulId).Eq("GORUNURLUK", 1).OrderBy("SIRA", OrderDirection.Asc).ToDataSet();
        }

        public DataSet GetAltMenuPer(int id, int kul)
        {
            var queryBase = new FrQueryBase(this.dbo);
            return queryBase.From("VIEW_KULLANICIMENU").Eq("DERINLIK", id).Eq("KULLANICI_ID", kul).Eq("GORUNURLUK", 1).OrderBy("SIRA", OrderDirection.Asc).ToDataSet();
        }

        public DataSet GetAlYetkiyiGetir(string verLink, int kul)
        {
            var queryBase = new FrQueryBase(this.dbo);
            return queryBase.From("VIEW_KULLANICIMENU").Eq("LINK", verLink).Eq("KULLANICI_ID", kul).ToDataSet();
        }

        public DataSet GetAllRecordsById(int id)
        {
            var queryBase = new FrQueryBase(this.dbo);
            return queryBase.From("ADM_MENU").Eq("ID", id).ToDataSet();
        }

        public bool YetkisiVarMi(string link, int id)
        {
            var queryBase = new FrQueryBase(this.dbo);
            var ds = queryBase.From("MENU").Eq("LINK", link).ToDataSet();

            if (ds.Tables[0].Rows.Count > 0)
            {
                var queryBase1 = new FrQueryBase(this.dbo);
                var ds1 = queryBase1.From("KULLANICI_MENU").Eq("MENU_ID", (int)ds.Tables[0].Rows[0][0]).Eq("KULLANICI_ID", id).ToDataSet();
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public int AltMenuSayiGetir(int menuId)
        {
            var query = new FrQueryBase(dbo);
            return int.Parse(query.Select("COUNT(*)").From("ADM_MENU").Eq("PARENTREF", menuId).ToDataSet().Tables[0].Rows[0][0].ToString());

        }

        public List<AdmMenu> GetMenuByLink(int kulId, string link, string lang)
        {
            var queryBase = new FrQueryBase(this.dbo);
            return queryBase.From("ADV_USER_MENU").Eq("LINK", link).Eq("USERREF", kulId).Eq("LANGU", lang).OrderBy("ORDERNO", OrderDirection.Asc).ToDataSet().ToFrList<AdmMenu>();
        }

        public List<AdmMenu> GetDataToClass(int id, int kul, int derinlik, int yetki, int aktif)
        {
            var queryBase = new FrQueryBase(this.dbo);

            queryBase.From("ADM_MENU");
            if (id > -1)
                queryBase.Eq("ID", id);
            if (kul > -1)
                queryBase.Eq("USERREF", kul);
            if (derinlik > -1)
                queryBase.Eq("PARENTREF", derinlik);
            if (yetki > -1)
                queryBase.Eq("AUTHLEVEL", yetki);
            if (aktif > -1)
                queryBase.Eq("ISACTIVE", aktif);

            return queryBase.OrderBy("ORDERNO", OrderDirection.Asc).ToDataSet().ToFrList<AdmMenu>();
        }

        public List<AdmMenu> GetAnaMenuPerToClass(int kulId, string lang)
        {
            var queryBase = new FrQueryBase(this.dbo);
            var result = queryBase.From("ADV_USER_MENU").Eq("PARENTREF", 1).Eq("USERREF", kulId).Eq("LANGU", lang).Eq("ISVISIBLE", 1).OrderBy("ORDERNO", OrderDirection.Asc).ToDataSet();
            return result.ToFrList<AdmMenu>();
        }

        public List<AdmMenu> GetAltMenuPerToClass(int id, int kul, string lang)
        {
            var queryBase = new FrQueryBase(this.dbo);
            return queryBase.From("ADV_USER_MENU").Eq("PARENTREF", id).Eq("USERREF", kul).Eq("LANGU", lang).Eq("ISVISIBLE", 1).OrderBy("ORDERNO", OrderDirection.Asc).ToDataSet().ToFrList<AdmMenu>();
        }


    }
}
