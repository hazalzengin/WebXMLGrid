using Sistem.DB.Model;
using Sistem.DB.Repo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sistem.DB.Service
{
    public class hazalusermenuservice : ServiceBase
    {
        private readonly hazalusermenurepo _itemRepo;

        public hazalusermenuservice(string ConStr)
        {
            ProgramConnection.ConStr = ConStr;
            _itemRepo = new hazalusermenurepo();
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

        public int Ekle(hazalusermenu item)
        {
            return _itemRepo.Insert(item);
        }

        public int Guncelle(hazalusermenu item)
        {
            return _itemRepo.Update(item);
        }

        public int Sil(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<hazalusermenu> GetItemClass(int userRef, int menuRef)
        {
            return _itemRepo.GetItemClass(userRef, menuRef);
        }
        public List<hazalusermenu> GetYetki(int userRef)
        {
            return _itemRepo.GetItemYetki(userRef);
        }

        public DataSet GetAll(int? userRef, int? menuRef)
        {
            return _itemRepo.GetAll(userRef, menuRef);
        }

        public void VerileriSil(int kul)
        {
            _itemRepo.VerileriSil(kul);
        }

    }

}
