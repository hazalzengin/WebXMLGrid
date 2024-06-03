using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmUsersService : ServiceBase 
    {
        private readonly AdmUsersRepo _itemRepo;

        public AdmUsersService(string ConStr)
        {
            ProgramConnection.ConStr = ConStr;
            _itemRepo = new AdmUsersRepo();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing == true)
            {
                _itemRepo.Dispose();
                // Managed kaynaklar icin 
            }
            base.Dispose(disposing);
            // UnManaged kaynaklar icin
        }

        public int Ekle(AdmUsers item)
        {
            return _itemRepo.Insert(item);
        }

        public int Guncelle(AdmUsers item)
        {
            return _itemRepo.Update(item);
        }

        public int Sil(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmUsers> GetItemClass(int id, int isDel)
        {
            return  _itemRepo.GetItemClass(id, isDel);
        }

        public List<AdmUsers> GetDataToClass(int id, String kullanici, String sifre, int aktif, int admin)
        {
            return _itemRepo.GetDataToClass(id, kullanici, sifre, aktif, admin);
        }

        public List<AdmUsers> GetDataFromWFUserCode(String userCode, int? isactive)
        {
            return _itemRepo.GetDataFromWFUserCode(userCode, isactive);
        }

        public List<AdmUsers> GetOfferAdminMail(String type, int? isactive)
        {
            return _itemRepo.GetOfferAdminMail(type, isactive);
        }
        public List<AdmUsers> GetDataFromEmail(String email, int aktif)
        {
            return _itemRepo.GetDataFromEmail(email, aktif);
        }

        public DataSet GetAll(int id, string LANGU, int isActive, int isDel)
        {
            return _itemRepo.GetAll(id, LANGU, isActive,isDel);
        }

    }
}
