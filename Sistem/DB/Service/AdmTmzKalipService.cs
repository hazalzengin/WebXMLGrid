using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmTmzKalipService : ServiceBase
    {
        private readonly AdmTmzKalipRepo _itemRepo;

        public AdmTmzKalipService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
            _itemRepo = new AdmTmzKalipRepo();
        }

        public int Add(AdmTmzKalip item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmTmzKalip item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
        {
            return _itemRepo.Delete(id);
        }

        public List<AdmTmzKalip> GetItemClass(int? Id, int? Itemref, string Itemcode, int? Makineref, string MakineCode, string Ebat, string Cilt, int? Isdel)
        {
            return _itemRepo.GetItemClass(Id, Itemref, Itemcode, Makineref, MakineCode, Ebat, Cilt, Isdel);
        }

        public DataSet GetAll(int? Id, int? Itemref, string Itemcode, int? Makineref, string MakineCode, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Itemref, Itemcode, Makineref, MakineCode, Isdel);
        }

    }
}
