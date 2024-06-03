using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmPrditemLotRepo : BaseRepository<AdmPrditemLot>
    {

        public List<AdmPrditemLot> GetItemClass(int? Id, int? Slref, int? Prditemref, int? Orderref, int? Oprref, int? Acceptoprref, int? Itemref, int? Lotref, string Lotcode, string Lotname, string Unit, string Whcode, DateTime? Skt, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PRDITEM_LOT");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);  
            
            if (Slref.HasValue)
                query.Eq("SLREF", Slref.Value);

            if (Prditemref.HasValue)
                query.Eq("PRDITEMREF", Prditemref.Value);

            if (Orderref.HasValue)
                query.Eq("ORDERREF", Orderref.Value);

            if (Oprref.HasValue)
                query.Eq("OPRREF", Oprref.Value);

            if (Acceptoprref.HasValue)
                query.Eq("ACCEPTOPRREF", Acceptoprref.Value);

            if (Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if (Lotref.HasValue)
                query.Eq("LOTREF", Lotref.Value);

            if (!string.IsNullOrWhiteSpace(Lotcode))
                query.Eq("LOTCODE", Lotcode);

            if (!string.IsNullOrWhiteSpace(Lotname))
                query.Eq("LOTNAME", Lotname);

            if (!string.IsNullOrWhiteSpace(Unit))
                query.Eq("UNIT", Unit);

            if (!string.IsNullOrWhiteSpace(Whcode))
                query.Eq("WHCODE", Whcode);

            if (Skt.HasValue)
                query.Eq("SKT", Skt.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmPrditemLot>();
        }

        public DataSet GetAll(int? Id, int? Slref, int? Prditemref, int? Orderref, int? Oprref, int? Itemref, int? Lotref, string Lotcode, string Lotname, string Unit, string Whcode, DateTime? Skt, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_PRDITEM_LOT");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Slref.HasValue)
                query.Eq("SLREF", Slref.Value);

            if (Prditemref.HasValue)
                query.Eq("PRDITEMREF", Prditemref.Value);

            if (Orderref.HasValue)
                query.Eq("ORDERREF", Orderref.Value);

            if (Oprref.HasValue)
                query.Eq("OPRREF", Oprref.Value);

            if (Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if (Lotref.HasValue)
                query.Eq("LOTREF", Lotref.Value);

            if (!string.IsNullOrWhiteSpace(Lotcode))
                query.Eq("LOTCODE", Lotcode);

            if (!string.IsNullOrWhiteSpace(Lotname))
                query.Eq("LOTNAME", Lotname);

            if (!string.IsNullOrWhiteSpace(Unit))
                query.Eq("UNIT", Unit);

            if (!string.IsNullOrWhiteSpace(Whcode))
                query.Eq("WHCODE", Whcode);

            if (Skt.HasValue)
                query.Eq("SKT", Skt.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
