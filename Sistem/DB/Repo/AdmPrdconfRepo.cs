using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmPrdconfRepo:BaseRepository<AdmPrdconf> 
    {

        public List<AdmPrdconf> GetItemClass(int? Id, int? Orderref, int? Oprref, int? Shiftref, int? Personelref, int? Isactive, int? Isdel, int? Transferstatus, int? Itemref, int? Confirmno, int? Confirmstatus)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PRDCONF");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Orderref.HasValue)
                query.Eq("ORDERREF", Orderref.Value);

            if(Oprref.HasValue)
                query.Eq("OPRREF", Oprref.Value);

            if(Shiftref.HasValue)
                query.Eq("SHIFTREF", Shiftref.Value);

            if(Personelref.HasValue)
                query.Eq("PERSONELREF", Personelref.Value);

            if(Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            if(Transferstatus.HasValue)
                query.Eq("TRANSFERSTATUS", Transferstatus.Value);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if(Confirmno.HasValue)
                query.Eq("CONFIRMNO", Confirmno.Value);

            if(Confirmstatus.HasValue)
                query.Eq("CONFIRMSTATUS", Confirmstatus.Value);

            return query.ToDataSet().ToFrList<AdmPrdconf>();
        }

        public DataSet GetAll(int? Id, int? Orderref, int? Oprref, int? Shiftref, int? Personelref, int? Isactive, int? Isdel, int? Transferstatus, int? Itemref, int? Confirmno, int? Confirmstatus)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PRDCONF");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Orderref.HasValue)
                query.Eq("ORDERREF", Orderref.Value);

            if(Oprref.HasValue)
                query.Eq("OPRREF", Oprref.Value);

            if(Shiftref.HasValue)
                query.Eq("SHIFTREF", Shiftref.Value);

            if(Personelref.HasValue)
                query.Eq("PERSONELREF", Personelref.Value);

            if(Isactive.HasValue)
                query.Eq("ISACTIVE", Isactive.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            if(Transferstatus.HasValue)
                query.Eq("TRANSFERSTATUS", Transferstatus.Value);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if(Confirmno.HasValue)
                query.Eq("CONFIRMNO", Confirmno.Value);

            if(Confirmstatus.HasValue)
                query.Eq("CONFIRMSTATUS", Confirmstatus.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
