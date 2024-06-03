using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmEnderEkmaliyetRepo:BaseRepository<AdmEnderEkmaliyet> 
    {

        public List<AdmEnderEkmaliyet> GetItemClass(int? Id, string Hamurkodu, string Maliyetkodu, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ENDER_EKMALIYET");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Hamurkodu))
                query.Eq("HAMURKODU", Hamurkodu);

            if(!string.IsNullOrWhiteSpace(Maliyetkodu))
                query.Eq("MALIYETKODU", Maliyetkodu);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmEnderEkmaliyet>();
        }

        public DataSet GetAll(int? Id, string Hamurkodu, string Maliyetkodu, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ENDER_EKMALIYET");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Hamurkodu))
                query.Eq("HAMURKODU", Hamurkodu);

            if(!string.IsNullOrWhiteSpace(Maliyetkodu))
                query.Eq("MALIYETKODU", Maliyetkodu);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
