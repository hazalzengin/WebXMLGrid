using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmSysReportcolumnService : ServiceBase 
    {
        private readonly AdmSysReportcolumnRepo _itemRepo;

        public AdmSysReportcolumnService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmSysReportcolumnRepo();
        } 

        public int Add(AdmSysReportcolumn item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmSysReportcolumn item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmSysReportcolumn> GetItemClass(int? Id, int? Headref, int? Columnorder, int? Type_, int? Isid, int? Hassubtotal, int? Subtotaltype, int? Visible, int? Cansort, int? Canfilter, int? Hasdetailpopup)
        {
            return  _itemRepo.GetItemClass(Id, Headref, Columnorder, Type_, Isid, Hassubtotal, Subtotaltype, Visible, Cansort, Canfilter, Hasdetailpopup);
        }

        public DataSet GetAll(int? Id, int? Headref, int? Columnorder, int? Type_, int? Isid, int? Hassubtotal, int? Subtotaltype, int? Visible, int? Cansort, int? Canfilter, int? Hasdetailpopup)
        {
            return _itemRepo.GetAll(Id, Headref, Columnorder, Type_, Isid, Hassubtotal, Subtotaltype, Visible, Cansort, Canfilter, Hasdetailpopup);
        }

    }
}
