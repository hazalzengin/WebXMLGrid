using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sistem.DB.Model;
using System.Data;
using kk.Ebank.DataAccess;
using System.Data.SqlClient;
using kk.Ebank.Mapper;


namespace Sistem.DB.Repo
{
    public class GenelRepo : BaseRepository<Object>
    {
        public DataSet RunSP(string procedureName, List<SqlParameter> pList)
        {
            var dbObject = String.IsNullOrEmpty(ProgramConnection.ConStr) ? new DbObject(0) : new DbObject(ProgramConnection.ConStr);
            var kkList = new SqlParameter[pList.Count - 1];
            for (int i = 0; i < pList.Count; i++)
            {
                kkList[i] = new SqlParameter(pList[i].ParameterName, pList[i].Value);
            }
            return dbObject.RunSPDataSet(procedureName, kkList);
        }

        public DataSet RunStorePrc(string sorgu)
        {
            var dbObject = String.IsNullOrEmpty(ProgramConnection.ConStr) ? new DbObject(0) : new DbObject(ProgramConnection.ConStr);
            var kParameter = new SqlParameter[1];
            kParameter[0] = new SqlParameter("@sorgu", sorgu);
            return dbObject.RunSPDataSet("sp_SorguCalistir", kParameter);
        }

        public int RunStorePrcCommand(string sorgu)
        {
            var dbObject = String.IsNullOrEmpty(ProgramConnection.ConStr) ? new DbObject(0) : new DbObject(ProgramConnection.ConStr);
            var kParameter = new SqlParameter[1];
            kParameter[0] = new SqlParameter("@sorgu", sorgu);
            return dbObject.RunSPNonQuery("sp_SorguCalistir", kParameter);
        }

        public DataSet RaporGetir(DateTime baslangic, DateTime bitis, String sorgu)
        {
            var dbObject = new DbObject(0);
            var kParameter = new SqlParameter[2];
            kParameter[0] = new SqlParameter("@baslangicTarihi", baslangic);
            kParameter[1] = new SqlParameter("@bitisTarihi", bitis);
            return dbObject.RunSPDataSet(sorgu, kParameter);
        }

        public DataSet DuyuruTurGetir()
        {
            var queryBase = new FrQueryBase(this.dbo);
            return queryBase.From("DUYURU_TURU").OrderBy("ID", OrderDirection.Asc).ToDataSet();
        }

        public DataSet GetCountry()
        {
            var query = new FrQueryBase(dbo);
            return query.From("ADM_COUNTRY").ToDataSet();
        }

        public DataSet GetCity(string countryRef)
        {
            var query = new FrQueryBase(dbo);
            return query.From("ADM_CITY").Eq("COUNTRYREF", countryRef).ToDataSet();
        }


        public DataSet ButunKayit(string tabloAdi, string idAlan)
        {
            String sorgu = "SELECT * FROM " + tabloAdi + " order by " + idAlan + " asc";
            return RunStorePrc(sorgu);
        }
    }
}
