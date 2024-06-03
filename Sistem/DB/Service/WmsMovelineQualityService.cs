using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class WmsMovelineQualityService : ServiceBase 
    {
        private readonly WmsMovelineQualityRepo _itemRepo;

        public WmsMovelineQualityService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new WmsMovelineQualityRepo();
        } 

        public int Add(WmsMovelineQuality item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(WmsMovelineQuality item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<WmsMovelineQuality> GetItemClass(int? Id, int? Orderref, int? Oprref, string Barcode, int? Qualitystatus)
        {
            return  _itemRepo.GetItemClass(Id, Orderref, Oprref, Barcode, Qualitystatus);
        }

        public DataSet GetAll(int? Id, int? Orderref, int? Oprref, string Barcode, int? Qualitystatus)
        {
            return _itemRepo.GetAll(Id, Orderref, Oprref, Barcode, Qualitystatus);
        }

    }
}
