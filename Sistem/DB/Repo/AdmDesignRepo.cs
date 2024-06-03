using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmDesignRepo:BaseRepository<AdmDesign> 
    {

        public List<AdmDesign> GetItemClass(int? Id, string Code, string Module, string Page, string Customer, string Langu, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_DESIGN");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Code))
                query.Eq("CODE", Code);

            if(!string.IsNullOrWhiteSpace(Module))
                query.Eq("MODULE", Module);

            if(!string.IsNullOrWhiteSpace(Page))
                query.Eq("PAGE", Page);

            if(!string.IsNullOrWhiteSpace(Customer))
                query.Eq("CUSTOMER", Customer);

            if(!string.IsNullOrWhiteSpace(Langu))
                query.Eq("LANGU", Langu);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmDesign>();
        }

        public DataSet GetAll(int? Id, string Code, string Module, string Page, string Customer, string Langu, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_DESIGN");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Code))
                query.Eq("CODE", Code);

            if(!string.IsNullOrWhiteSpace(Module))
                query.Eq("MODULE", Module);

            if(!string.IsNullOrWhiteSpace(Page))
                query.Eq("PAGE", Page);

            if(!string.IsNullOrWhiteSpace(Customer))
                query.Eq("CUSTOMER", Customer);

            if(!string.IsNullOrWhiteSpace(Langu))
                query.Eq("LANGU", Langu);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
