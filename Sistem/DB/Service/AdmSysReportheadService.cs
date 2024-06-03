using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmSysReportheadService : ServiceBase 
    {
        private readonly AdmSysReportheadRepo _itemRepo;

        public AdmSysReportheadService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmSysReportheadRepo();
        } 

        public int Add(AdmSysReporthead item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmSysReporthead item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmSysReporthead> GetItemClass(int? Id, String code,int? Hasdatefilter, int? Hasclfilter, int? Clfiltertype, int? Hasitemfilter, int? Itemfiltertype, int? Haswhfilter, int? Whfiltertype, int? Hassalesmanfilter, int? Salesmanfiltertype, int? Hasbranchfilter, int? Branchfiltertype)
        {
            return  _itemRepo.GetItemClass(Id, code,Hasdatefilter, Hasclfilter, Clfiltertype, Hasitemfilter, Itemfiltertype, Haswhfilter, Whfiltertype, Hassalesmanfilter, Salesmanfiltertype, Hasbranchfilter, Branchfiltertype);
        }

        public DataSet GetAll(int? Id, int? Hasdatefilter, int? Hasclfilter, int? Clfiltertype, int? Hasitemfilter, int? Itemfiltertype, int? Haswhfilter, int? Whfiltertype, int? Hassalesmanfilter, int? Salesmanfiltertype, int? Hasbranchfilter, int? Branchfiltertype)
        {
            return _itemRepo.GetAll(Id, Hasdatefilter, Hasclfilter, Clfiltertype, Hasitemfilter, Itemfiltertype, Haswhfilter, Whfiltertype, Hassalesmanfilter, Salesmanfiltertype, Hasbranchfilter, Branchfiltertype);
        }

    }
}
