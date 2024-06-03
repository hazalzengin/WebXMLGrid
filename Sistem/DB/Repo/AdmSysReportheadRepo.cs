using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmSysReportheadRepo:BaseRepository<AdmSysReporthead> 
    {

        public List<AdmSysReporthead> GetItemClass(int? Id,String code, int? Hasdatefilter, int? Hasclfilter, int? Clfiltertype
            , int? Hasitemfilter, int? Itemfiltertype, int? Haswhfilter, int? Whfiltertype, int? Hassalesmanfilter, int? Salesmanfiltertype
            , int? Hasbranchfilter, int? Branchfiltertype)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_SYS_REPORTHEAD");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if (!String.IsNullOrEmpty(code)) query.Eq("REPORTCODE", code);

            if(Hasdatefilter.HasValue)
                query.Eq("HASDATEFILTER", Hasdatefilter.Value);

            if(Hasclfilter.HasValue)
                query.Eq("HASCLFILTER", Hasclfilter.Value);

            if(Clfiltertype.HasValue)
                query.Eq("CLFILTERTYPE", Clfiltertype.Value);

            if(Hasitemfilter.HasValue)
                query.Eq("HASITEMFILTER", Hasitemfilter.Value);

            if(Itemfiltertype.HasValue)
                query.Eq("ITEMFILTERTYPE", Itemfiltertype.Value);

            if(Haswhfilter.HasValue)
                query.Eq("HASWHFILTER", Haswhfilter.Value);

            if(Whfiltertype.HasValue)
                query.Eq("WHFILTERTYPE", Whfiltertype.Value);

            if(Hassalesmanfilter.HasValue)
                query.Eq("HASSALESMANFILTER", Hassalesmanfilter.Value);

            if(Salesmanfiltertype.HasValue)
                query.Eq("SALESMANFILTERTYPE", Salesmanfiltertype.Value);

            if(Hasbranchfilter.HasValue)
                query.Eq("HASBRANCHFILTER", Hasbranchfilter.Value);

            if(Branchfiltertype.HasValue)
                query.Eq("BRANCHFILTERTYPE", Branchfiltertype.Value);

            return query.ToDataSet().ToFrList<AdmSysReporthead>();
        }

        public DataSet GetAll(int? Id, int? Hasdatefilter, int? Hasclfilter, int? Clfiltertype, int? Hasitemfilter, int? Itemfiltertype, int? Haswhfilter, int? Whfiltertype, int? Hassalesmanfilter, int? Salesmanfiltertype, int? Hasbranchfilter, int? Branchfiltertype)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_SYS_REPORTHEAD");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Hasdatefilter.HasValue)
                query.Eq("HASDATEFILTER", Hasdatefilter.Value);

            if(Hasclfilter.HasValue)
                query.Eq("HASCLFILTER", Hasclfilter.Value);

            if(Clfiltertype.HasValue)
                query.Eq("CLFILTERTYPE", Clfiltertype.Value);

            if(Hasitemfilter.HasValue)
                query.Eq("HASITEMFILTER", Hasitemfilter.Value);

            if(Itemfiltertype.HasValue)
                query.Eq("ITEMFILTERTYPE", Itemfiltertype.Value);

            if(Haswhfilter.HasValue)
                query.Eq("HASWHFILTER", Haswhfilter.Value);

            if(Whfiltertype.HasValue)
                query.Eq("WHFILTERTYPE", Whfiltertype.Value);

            if(Hassalesmanfilter.HasValue)
                query.Eq("HASSALESMANFILTER", Hassalesmanfilter.Value);

            if(Salesmanfiltertype.HasValue)
                query.Eq("SALESMANFILTERTYPE", Salesmanfiltertype.Value);

            if(Hasbranchfilter.HasValue)
                query.Eq("HASBRANCHFILTER", Hasbranchfilter.Value);

            if(Branchfiltertype.HasValue)
                query.Eq("BRANCHFILTERTYPE", Branchfiltertype.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
