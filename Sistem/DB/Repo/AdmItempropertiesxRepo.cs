using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmItempropertiesxRepo:BaseRepository<AdmItempropertiesx> 
    {

        public List<AdmItempropertiesx> GetItemClass(int? Id, int? Refid)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ITEMPROPERTIESx");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Refid.HasValue)
                query.Eq("REFID", Refid.Value);

            return query.ToDataSet().ToFrList<AdmItempropertiesx>();
        }

        public DataSet GetAll()
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ITEMPROPERTIESx");
            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
