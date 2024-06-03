using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmTmzItemMachineRepo:BaseRepository<AdmTmzItemMachine> 
    {

        public List<AdmTmzItemMachine> GetItemClass(int? Id, string Itemcode, int? IcMakineref, string IcMakineCode, int? ArtikMakineref, int? KapakMakineref, string KapakMakineCode)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_TMZ_ITEM_MACHINE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if(IcMakineref.HasValue)
                query.Eq("IC_MAKINEREF", IcMakineref.Value);

            if(!string.IsNullOrWhiteSpace(IcMakineCode))
                query.Eq("IC_MAKINE_CODE", IcMakineCode);

            if(ArtikMakineref.HasValue)
                query.Eq("ARTIK_MAKINEREF", ArtikMakineref.Value);

            if(KapakMakineref.HasValue)
                query.Eq("KAPAK_MAKINEREF", KapakMakineref.Value);

            if(!string.IsNullOrWhiteSpace(KapakMakineCode))
                query.Eq("KAPAK_MAKINE_CODE", KapakMakineCode);

            return query.ToDataSet().ToFrList<AdmTmzItemMachine>();
        }

        public DataSet GetAll(int? Id, string Itemcode, int? IcMakineref, string IcMakineCode, int? ArtikMakineref, int? KapakMakineref, string KapakMakineCode)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_TMZ_ITEM_MACHINE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if(IcMakineref.HasValue)
                query.Eq("IC_MAKINEREF", IcMakineref.Value);

            if(!string.IsNullOrWhiteSpace(IcMakineCode))
                query.Eq("IC_MAKINE_CODE", IcMakineCode);

            if(ArtikMakineref.HasValue)
                query.Eq("ARTIK_MAKINEREF", ArtikMakineref.Value);

            if(KapakMakineref.HasValue)
                query.Eq("KAPAK_MAKINEREF", KapakMakineref.Value);

            if(!string.IsNullOrWhiteSpace(KapakMakineCode))
                query.Eq("KAPAK_MAKINE_CODE", KapakMakineCode);

            return query.OrderBy("ID", OrderDirection.Asc).ToDataSet();
        }


    }
}
