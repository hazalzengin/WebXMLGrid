using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class GenelService : ServiceBase
    {
        private readonly GenelRepo _genelRepo;

        public GenelService(string ConStr)
        {
            ProgramConnection.ConStr = ConStr;
            _genelRepo = new GenelRepo();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing == true)
            {
                _genelRepo.Dispose();
                // Managed kaynaklar icin 
            }
            base.Dispose(disposing);
            // UnManaged kaynaklar icin
        }

        public DataSet RunStorePrc(String sorgu)
        {
            return _genelRepo.RunStorePrc(sorgu);
        }

        public int RunStorePrcCommand(String sorgu)
        {
            return _genelRepo.RunStorePrcCommand(sorgu);
        }

        public DataSet RaporGetir(DateTime baslangic, DateTime bitis, String sorgu)
        {
            return _genelRepo.RaporGetir(baslangic, bitis, sorgu);
        }

        public DataSet GetCountry()
        {
            return _genelRepo.GetCountry();
        }

        public DataSet GetCity(string countryRef)
        {
            return _genelRepo.GetCity(countryRef);
        }

        public DataSet ButunKayit(String tabloAdi, String idAlan)
        {
            return _genelRepo.ButunKayit(tabloAdi, idAlan);
        }

    }
}
