using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmUsersRepo : BaseRepository<AdmUsers>
    {
        LoginHashing _loginHashing = new LoginHashing();
        public List<AdmUsers> GetItemClass(int id, int isDel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_USERS");

            if (id > -1)
            {
                query.Eq("ID", id);
            }
            if (isDel > -1)
                query.Eq("ISDEL", isDel);
            return query.ToDataSet().ToFrList<AdmUsers>();
        }

        public List<AdmUsers> GetDataToClass(int id, String kullanici, String sifre, int aktif, int admin)
        {
            var queryBase = new FrQueryBase(this.dbo);
            queryBase.From("ADM_USERS");
            if (id > -1)
                queryBase.Eq("ID", id);
            if (kullanici != null)
                queryBase.Eq("USERNAME", kullanici);
            if (sifre != null)
                queryBase.Eq("PASSWORD", _loginHashing.Encrypt(sifre));
            if (aktif > -1)
                queryBase.Eq("ISACTIVE", aktif);
            return queryBase.OrderBy("ID", OrderDirection.Desc).ToDataSet().ToFrList<AdmUsers>();
        }



        public List<AdmUsers> GetDataFromWFUserCode(String userCode, int? isactive)
        {
            var query = new FrQueryBase(this.dbo);
            query.From("ADM_USERS");

            if (!string.IsNullOrWhiteSpace(userCode))
            {
                query.Eq("WFUSERCODE", userCode);
            }
            if (isactive.HasValue)
                query.Eq("ISACTIVE", isactive.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet().ToFrList<AdmUsers>();
        }

        public List<AdmUsers> GetOfferAdminMail(String type, int? isactive)
        {
            var query = new FrQueryBase(this.dbo);
            query.From("ADM_USERS");

            if (!string.IsNullOrWhiteSpace(type))
            {
                query.Eq("MAILSENDTYPE", type);
            }
            if (isactive.HasValue)
                query.Eq("ISACTIVE", isactive.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet().ToFrList<AdmUsers>();
        }

        public List<AdmUsers> GetDataFromEmail(String email, int aktif)
        {
            var queryBase = new FrQueryBase(this.dbo);
            queryBase.From("ADM_USERS");
            if (email != null)
                queryBase.Eq("EMAIL", email);
            if (aktif > -1)
                queryBase.Eq("ISACTIVE", aktif);
            return queryBase.OrderBy("ID", OrderDirection.Desc).ToDataSet().ToFrList<AdmUsers>();
        }

        public DataSet GetAll(int id, string LANGU, int isActive, int isDel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_USERS");

            if (id > -1)
            {
                query.Eq("ID", id);
            }
            if (!string.IsNullOrWhiteSpace(LANGU))
            {
                query.Eq("LANGU", LANGU);
            }

            if (isActive > -1)
            {
                query.Eq("ISACTIVE", isActive);
            }
            if (isDel > -1)
            {
                query.Eq("ISDEL", isDel);
            }

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
