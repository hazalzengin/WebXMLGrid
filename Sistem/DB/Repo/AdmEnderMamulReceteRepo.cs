using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmEnderMamulReceteRepo:BaseRepository<AdmEnderMamulRecete> 
    {

        public List<AdmEnderMamulRecete> GetItemClass(int? Id, string Kodu, string Eskikodu, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ENDER_MAMUL_RECETE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Kodu))
                query.Eq("KODU", Kodu);

            if(!string.IsNullOrWhiteSpace(Eskikodu))
                query.Eq("ESKIKODU", Eskikodu);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmEnderMamulRecete>();
        }

        public DataSet GetAll(int? Id, string Kodu, string Eskikodu, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ENDER_MAMUL_RECETE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Kodu))
                query.Eq("KODU", Kodu);

            if(!string.IsNullOrWhiteSpace(Eskikodu))
                query.Eq("ESKIKODU", Eskikodu);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
