using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class WmsWhcheckheadRepo:BaseRepository<WmsWhcheckhead> 
    {

        public List<WmsWhcheckhead> GetItemClass(int? Id, int? Branch, int? Sourceindex, int? Iscompleted, int? Moveficheref, int? Iscountfiche, int? Isopenfiche, int? Willtransfer,DateTime? dtDate)
        {
            var query = new FrQueryBase(dbo);
            query.From("WMS_WHCHECKHEAD");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Branch.HasValue)
                query.Eq("BRANCH", Branch.Value);

            if(Sourceindex.HasValue)
                query.Eq("SOURCEINDEX", Sourceindex.Value);

            if(Iscompleted.HasValue)
                query.Eq("ISCOMPLETED", Iscompleted.Value);

            if(Moveficheref.HasValue)
                query.Eq("MOVEFICHEREF", Moveficheref.Value);

            if(Iscountfiche.HasValue)
                query.Eq("ISCOUNTFICHE", Iscountfiche.Value);

            if(Isopenfiche.HasValue)
                query.Eq("ISOPENFICHE", Isopenfiche.Value);

            if(Willtransfer.HasValue)
                query.Eq("WILLTRANSFER", Willtransfer.Value);

            if (dtDate.HasValue)
                query.Eq("DATE_", dtDate.Value);

            return query.ToDataSet().ToFrList<WmsWhcheckhead>();
        }

        public DataSet GetAll(int? Id, int? Branch, int? Sourceindex, int? Iscompleted, int? Moveficheref, int? Iscountfiche, int? Isopenfiche, int? Willtransfer, DateTime? dtDate)
        {
            var query = new FrQueryBase(dbo);
            query.From("WMS_WHCHECKHEAD");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Branch.HasValue)
                query.Eq("BRANCH", Branch.Value);

            if (Sourceindex.HasValue)
                query.Eq("SOURCEINDEX", Sourceindex.Value);

            if (Iscompleted.HasValue)
                query.Eq("ISCOMPLETED", Iscompleted.Value);

            if (Moveficheref.HasValue)
                query.Eq("MOVEFICHEREF", Moveficheref.Value);

            if (Iscountfiche.HasValue)
                query.Eq("ISCOUNTFICHE", Iscountfiche.Value);

            if (Isopenfiche.HasValue)
                query.Eq("ISOPENFICHE", Isopenfiche.Value);

            if (Willtransfer.HasValue)
                query.Eq("WILLTRANSFER", Willtransfer.Value);

            if (dtDate.HasValue)
                query.Eq("DATE_", dtDate.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
