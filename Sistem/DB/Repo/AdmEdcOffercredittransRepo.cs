using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmEdcOffercredittransRepo:BaseRepository<AdmEdcOffercredittrans> 
    {

        public List<AdmEdcOffercredittrans> GetItemClass(int? Id, int? Creditref, int? Offerref, int? Iocode, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_EDC_OFFERCREDITTRANS");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Creditref.HasValue)
                query.Eq("CREDITREF", Creditref.Value);

            if(Offerref.HasValue)
                query.Eq("OFFERREF", Offerref.Value);

            if(Iocode.HasValue)
                query.Eq("IOCODE", Iocode.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmEdcOffercredittrans>();
        }

        public DataSet GetAll(int? Id, int? Creditref, int? Offerref, int? Iocode, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_EDC_OFFERCREDITTRANS");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Creditref.HasValue)
                query.Eq("CREDITREF", Creditref.Value);

            if(Offerref.HasValue)
                query.Eq("OFFERREF", Offerref.Value);

            if(Iocode.HasValue)
                query.Eq("IOCODE", Iocode.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
