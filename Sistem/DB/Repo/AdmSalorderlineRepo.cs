using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmSalorderlineRepo:BaseRepository<AdmSalorderline> 
    {

        public List<AdmSalorderline> GetItemClass(int? Id, int? Headref, int? Itemref, int? Iscompleted)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_SALORDERLINE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Headref.HasValue)
                query.Eq("HEADREF", Headref.Value);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if(Iscompleted.HasValue)
                query.Eq("ISCOMPLETED", Iscompleted.Value);

            return query.ToDataSet().ToFrList<AdmSalorderline>();
        }

        public DataSet GetAll(int? Id, int? Headref, int? Itemref, int? Iscompleted)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_SALORDERLINE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Headref.HasValue)
                query.Eq("HEADREF", Headref.Value);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if(Iscompleted.HasValue)
                query.Eq("ISCOMPLETED", Iscompleted.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
