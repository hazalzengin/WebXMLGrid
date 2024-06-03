using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class WmsMoveficheRepo:BaseRepository<WmsMovefiche> 
    {

        public List<WmsMovefiche> GetItemClass(int? Id, int? Trcode, int? Salestype, int? Purchasetype, int? Clientref, string Clcode, int? Isdelete, int? Istransferred, int? Lficheref, int? WmsRef)
        {
            var query = new FrQueryBase(dbo);
            query.From("WMS_MOVEFICHE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Trcode.HasValue)
                query.Eq("TRCODE", Trcode.Value);

            if(Salestype.HasValue)
                query.Eq("SALESTYPE", Salestype.Value);

            if(Purchasetype.HasValue)
                query.Eq("PURCHASETYPE", Purchasetype.Value);

            if(Clientref.HasValue)
                query.Eq("CLIENTREF", Clientref.Value);

            if(!string.IsNullOrWhiteSpace(Clcode))
                query.Eq("CLCODE", Clcode);

            if(Isdelete.HasValue)
                query.Eq("ISDELETE", Isdelete.Value);

            if(Istransferred.HasValue)
                query.Eq("ISTRANSFERRED", Istransferred.Value);

            if(Lficheref.HasValue)
                query.Eq("LFICHEREF", Lficheref.Value);          
            
            if(WmsRef.HasValue)
                query.Eq("WMSREF", WmsRef.Value);

            return query.ToDataSet().ToFrList<WmsMovefiche>();
        }

        public DataSet GetAll(int? Id, int? Trcode, int? Salestype, int? Purchasetype, int? Clientref, string Clcode, int? Isdelete, int? Istransferred, int? Lficheref)
        {
            var query = new FrQueryBase(dbo);
            query.From("WMS_MOVEFICHE");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Trcode.HasValue)
                query.Eq("TRCODE", Trcode.Value);

            if(Salestype.HasValue)
                query.Eq("SALESTYPE", Salestype.Value);

            if(Purchasetype.HasValue)
                query.Eq("PURCHASETYPE", Purchasetype.Value);

            if(Clientref.HasValue)
                query.Eq("CLIENTREF", Clientref.Value);

            if(!string.IsNullOrWhiteSpace(Clcode))
                query.Eq("CLCODE", Clcode);

            if(Isdelete.HasValue)
                query.Eq("ISDELETE", Isdelete.Value);

            if(Istransferred.HasValue)
                query.Eq("ISTRANSFERRED", Istransferred.Value);

            if(Lficheref.HasValue)
                query.Eq("LFICHEREF", Lficheref.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
