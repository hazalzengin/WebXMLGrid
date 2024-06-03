using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmExcellTemplateRepo:BaseRepository<AdmExcellTemplate> 
    {

        public List<AdmExcellTemplate> GetItemClass(int? Id, string Pagename, string Fieldname, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_EXCELL_TEMPLATE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Pagename))
                query.Eq("PAGENAME", Pagename);

            if(!string.IsNullOrWhiteSpace(Fieldname))
                query.Eq("FIELDNAME", Fieldname);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmExcellTemplate>();
        }

        public DataSet GetAll(int? Id, string Pagename, string Fieldname, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_EXCELL_TEMPLATE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Pagename))
                query.Eq("PAGENAME", Pagename);

            if(!string.IsNullOrWhiteSpace(Fieldname))
                query.Eq("FIELDNAME", Fieldname);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
