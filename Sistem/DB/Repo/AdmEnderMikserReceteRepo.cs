using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmEnderMikserReceteRepo:BaseRepository<AdmEnderMikserRecete> 
    {

        public List<AdmEnderMikserRecete> GetItemClass(int? Id, string Tur, string Hamurkodu, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ENDER_MIKSER_RECETE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Tur))
                query.Eq("TUR", Tur);

            if(!string.IsNullOrWhiteSpace(Hamurkodu))
                query.Eq("HAMURKODU", Hamurkodu);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmEnderMikserRecete>();
        }

        public DataSet GetAll(int? Id, string Tur, string Hamurkodu, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ENDER_MIKSER_RECETE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Tur))
                query.Eq("TUR", Tur);

            if(!string.IsNullOrWhiteSpace(Hamurkodu))
                query.Eq("HAMURKODU", Hamurkodu);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
