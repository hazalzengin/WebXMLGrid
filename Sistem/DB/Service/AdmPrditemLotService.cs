using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmPrditemLotService : ServiceBase
    {
        private readonly AdmPrditemLotRepo _itemRepo;

        public AdmPrditemLotService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmPrditemLotRepo();
        }

        public int Add(AdmPrditemLot item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmPrditemLot item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmPrditemLot> GetItemClass(int? Id, int? Slref, int? Prditemref, int? Orderref, int? Oprref, int? Acceptoprref, int? Itemref, int? Lotref, string Lotcode, string Lotname, string Unit, string Whcode, DateTime? Skt, int? Isdel)
        {
            return _itemRepo.GetItemClass(Id, Slref, Prditemref, Orderref, Oprref, Acceptoprref, Itemref, Lotref, Lotcode, Lotname, Unit, Whcode, Skt, Isdel);
        }

        public DataSet GetAll(int? Id, int? Slref, int? Prditemref, int? Orderref, int? Oprref, int? Itemref, int? Lotref, string Lotcode, string Lotname, string Unit, string Whcode, DateTime? Skt, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Slref, Prditemref, Orderref, Oprref, Itemref, Lotref, Lotcode, Lotname, Unit, Whcode, Skt, Isdel);
        }

    }
}
