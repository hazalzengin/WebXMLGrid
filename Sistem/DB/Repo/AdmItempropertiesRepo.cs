using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmItempropertiesRepo:BaseRepository<AdmItemproperties> 
    {

        public List<AdmItemproperties> GetItemClass(int? Id, string Type, int? Isactive, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ITEMPROPERTIES");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Type))
                query.Eq("TYPE", Type);

            if(Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmItemproperties>();
        }

        public DataSet GetAll()
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_ITEMPROPERTIES");
            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }

        public DataSet GetAll(int? id, string LANGU, string TYPE, int? isActive, int? isDel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADV_ITEMPROPERTIES");

            if (id.HasValue)
            {
                query.Eq("ID", id);
            }

            if (!string.IsNullOrWhiteSpace(TYPE))
            {
                query.Eq("TYPE", TYPE);
            }

            if (!string.IsNullOrWhiteSpace(LANGU))
            {
                query.Eq("LANGU", LANGU);
            }
            if (isActive.HasValue)
            {
                query.Eq("ISACTIVE", isActive);
            }
            if (isDel.HasValue)
            {
                query.Eq("ISDEL", isDel);
            }
            return query.OrderBy("ID", OrderDirection.Asc).ToDataSet();
        }


    }
}
