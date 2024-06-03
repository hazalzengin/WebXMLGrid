using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmParamsxRepo:BaseRepository<AdmParamsx> 
    {

        public List<AdmParamsx> GetItemClass(int? Id, int? Refid)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PARAMSx");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Refid.HasValue)
                query.Eq("REFID", Refid.Value);

            return query.ToDataSet().ToFrList<AdmParamsx>();
        }

        public DataSet GetAll()
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PARAMSx");
            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
