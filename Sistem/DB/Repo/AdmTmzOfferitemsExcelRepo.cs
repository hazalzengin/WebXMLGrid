using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmTmzOfferitemsExcelRepo:BaseRepository<AdmTmzOfferitemsExcel> 
    {

        public List<AdmTmzOfferitemsExcel> GetItemClass(int? Id, int? Parentref, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_TMZ_OFFERITEMS_EXCEL");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Parentref.HasValue)
                query.Eq("PARENTREF", Parentref.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet().ToFrList<AdmTmzOfferitemsExcel>();
        }

        public DataSet GetAll(int? Id, int? Parentref,int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_TMZ_OFFERITEMS_EXCEL");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Parentref.HasValue)
                query.Eq("PARENTREF", Parentref.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
