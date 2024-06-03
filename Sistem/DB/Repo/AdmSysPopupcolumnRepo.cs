using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmSysPopupcolumnRepo:BaseRepository<AdmSysPopupcolumn> 
    {

        public List<AdmSysPopupcolumn> GetItemClass(int? Id, int? Popupref)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_SYS_POPUPCOLUMN");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Popupref.HasValue)
                query.Eq("POPUPREF", Popupref.Value);

            return query.OrderBy("COLUMNORDER",OrderDirection.Asc).ToDataSet().ToFrList<AdmSysPopupcolumn>();
        }

        public DataSet GetAll(int? Id, int? Popupref)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_SYS_POPUPCOLUMN");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Popupref.HasValue)
                query.Eq("POPUPREF", Popupref.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
