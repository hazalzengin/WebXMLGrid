using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmEnderAlisbirimmaliyetRepo:BaseRepository<AdmEnderAlisbirimmaliyet> 
    {

        public List<AdmEnderAlisbirimmaliyet> GetItemClass(int? Id, string StokKodu)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ENDER_ALISBIRIMMALIYET");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(StokKodu))
                query.Eq("STOK_KODU", StokKodu);

            return query.ToDataSet().ToFrList<AdmEnderAlisbirimmaliyet>();
        }

        public DataSet GetAll(int? Id, string StokKodu)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ENDER_ALISBIRIMMALIYET");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(StokKodu))
                query.Eq("STOK_KODU", StokKodu);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
