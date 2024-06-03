using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmLoadingorderitemsRepo:BaseRepository<AdmLoadingorderitems> 
    {

        public List<AdmLoadingorderitems> GetItemClass(int? Id, int? Loadingorderref, int? Orderref, string Clcardcode, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_LOADINGORDERITEMS");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Loadingorderref.HasValue)
                query.Eq("LOADINGORDERREF", Loadingorderref.Value);

            if (Orderref.HasValue)
                query.Eq("ORDERREF", Orderref.Value);

            if (!string.IsNullOrWhiteSpace(Clcardcode))
                query.Eq("CLCARDCODE", Clcardcode);


            if(Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmLoadingorderitems>();
        }

        public DataSet GetAll(int? Loadingorderref, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_LOADINGORDERITEMS");

            if (Loadingorderref.HasValue)
                query.Eq("LOADINGORDERREF", Loadingorderref.Value);

            if (Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
