using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmMenuService : ServiceBase
    {
        private readonly AdmMenuRepo _itemRepo;

        public AdmMenuService(string ConStr)
        {
            ProgramConnection.ConStr = ConStr;
            _itemRepo = new AdmMenuRepo();
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

        public int Ekle(AdmMenu item)
        {
            return _itemRepo.Insert(item);
        }

        public int Guncelle(AdmMenu item)
        {
            return _itemRepo.Update(item);
        }

        public int Sil(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmMenu> GetItemClass(int id)
        {
            return _itemRepo.GetItemClass(id);
        }

        public DataSet GetAll(string LANGU, string PARENTREF, int isActive)
        {
            return _itemRepo.GetAll(LANGU, PARENTREF, isActive);
        }


        public DataSet GetAnaMenu()
        {
            return _itemRepo.GetAnaMenu();
        }

        public DataSet GetAltMenu(int id)
        {
            return _itemRepo.GetAltMenu(id);
        }

        public List<AdmMenu> GetAnaMenuPerToClass(int kulId, string lang)
        {
            return _itemRepo.GetAnaMenuPerToClass(kulId, lang);
        }


        public List<AdmMenu> GetMenuByLink(int kulId, string link, string lang)
        {
            return _itemRepo.GetMenuByLink(kulId, link, lang);
        }

        public List<AdmMenu> GetDataToClass(int id, int kul, int derinlik, int yetki, int aktif)
        {
            return _itemRepo.GetDataToClass(id, kul, derinlik, yetki, aktif);
        }
        public List<AdmMenu> GetAltMenuPerToClass(int id, int kul, string lang)
        {
            return _itemRepo.GetAltMenuPerToClass(id, kul, lang);
        }

        public DataSet GetAnaMenuPer(int kulId)
        {
            return _itemRepo.GetAnaMenuPer(kulId);
        }

        public DataSet GetAltMenuPer(int id, int kul)
        {
            return _itemRepo.GetAltMenuPer(id, kul);
        }

        public DataSet GetAlYetkiyiGetir(string verLink, int kul)
        {
            return _itemRepo.GetAlYetkiyiGetir(verLink, kul);
        }

        public DataSet GetAllRecordsById(int id)
        {
            return _itemRepo.GetAllRecordsById(id);
        }

        public bool YetkisiVarmi(string link, int id)
        {
            return _itemRepo.YetkisiVarMi(link, id);
        }

        public int AltMenuSayiGetir(int menuID)
        {
            return _itemRepo.AltMenuSayiGetir(menuID);
        }

    }
}
