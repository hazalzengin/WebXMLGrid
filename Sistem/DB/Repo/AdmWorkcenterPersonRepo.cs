using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmWorkcenterPersonRepo:BaseRepository<AdmWorkcenterPerson> 
    {

        public List<AdmWorkcenterPerson> GetItemClass(int? Id, int? Workcenterref, int? Userref, int? Hasmainperson)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_WORKCENTER_PERSON");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Workcenterref.HasValue)
                query.Eq("WORKCENTERREF", Workcenterref.Value);

            if(Userref.HasValue)
                query.Eq("USERREF", Userref.Value);

            if(Hasmainperson.HasValue)
                query.Eq("HASMAINPERSON", Hasmainperson.Value);

            return query.ToDataSet().ToFrList<AdmWorkcenterPerson>();
        }

        public DataSet GetAll(int? Id, int? Workcenterref, int? Userref, int? Hasmainperson)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_WORKCENTER_PERSON");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Workcenterref.HasValue)
                query.Eq("WORKCENTERREF", Workcenterref.Value);

            if(Userref.HasValue)
                query.Eq("USERREF", Userref.Value);

            if(Hasmainperson.HasValue)
                query.Eq("HASMAINPERSON", Hasmainperson.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
