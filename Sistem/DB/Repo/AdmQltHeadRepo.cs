using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmQltHeadRepo:BaseRepository<AdmQltHead> 
    {

        public List<AdmQltHead> GetItemClass(int? Id, int? Paramref, string Analysisno, DateTime? Analysisdate, DateTime? Orderdate_, DateTime? Orderduedate, string Ficheno, int? Stficheref, int? Stlineref, int? Itemref, string Itemcode, int? Clref, string Clcode, string Clname, int? Qltstatus, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_QLT_HEAD");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(Paramref.HasValue)
                query.Eq("PARAMREF", Paramref.Value);

            if (!string.IsNullOrWhiteSpace(Analysisno))
                query.Eq("ANALYSISNO", Analysisno);

            if (Analysisdate.HasValue)
                query.Eq("ANALYSISDATE", Analysisdate.Value);

            if (Orderdate_.HasValue)
                query.Eq("ORDERDATE_", Orderdate_.Value);

            if(Orderduedate.HasValue)
                query.Eq("ORDERDUEDATE", Orderduedate.Value);

            if(!string.IsNullOrWhiteSpace(Ficheno))
                query.Eq("FICHENO", Ficheno);

            if(Stficheref.HasValue)
                query.Eq("STFICHEREF", Stficheref.Value);

            if(Stlineref.HasValue)
                query.Eq("STLINEREF", Stlineref.Value);

            if(Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if(!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if(Clref.HasValue)
                query.Eq("CLREF", Clref.Value);

            if(!string.IsNullOrWhiteSpace(Clcode))
                query.Eq("CLCODE", Clcode);

            if(!string.IsNullOrWhiteSpace(Clname))
                query.Eq("CLNAME", Clname);

            if(Qltstatus.HasValue)
                query.Eq("QLTSTATUS", Qltstatus.Value);

            if(Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.ToDataSet().ToFrList<AdmQltHead>();
        }

        public DataSet GetAll(int? Id, int? Paramref, string Analysisno, DateTime? Analysisdate, DateTime? Orderdate_, DateTime? Orderduedate, string Ficheno, int? Stficheref, int? Stlineref, int? Itemref, string Itemcode, int? Clref, string Clcode, string Clname, int? Qltstatus, int? Isdel)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_QLT_HEAD");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (Paramref.HasValue)
                query.Eq("PARAMREF", Paramref.Value);

            if (!string.IsNullOrWhiteSpace(Analysisno))
                query.Eq("ANALYSISNO", Analysisno);

            if (Analysisdate.HasValue)
                query.Eq("ANALYSISDATE", Analysisdate.Value);

            if (Orderdate_.HasValue)
                query.Eq("ORDERDATE_", Orderdate_.Value);

            if (Orderduedate.HasValue)
                query.Eq("ORDERDUEDATE", Orderduedate.Value);

            if (!string.IsNullOrWhiteSpace(Ficheno))
                query.Eq("FICHENO", Ficheno);

            if (Stficheref.HasValue)
                query.Eq("STFICHEREF", Stficheref.Value);

            if (Stlineref.HasValue)
                query.Eq("STLINEREF", Stlineref.Value);

            if (Itemref.HasValue)
                query.Eq("ITEMREF", Itemref.Value);

            if (!string.IsNullOrWhiteSpace(Itemcode))
                query.Eq("ITEMCODE", Itemcode);

            if (Clref.HasValue)
                query.Eq("CLREF", Clref.Value);

            if (!string.IsNullOrWhiteSpace(Clcode))
                query.Eq("CLCODE", Clcode);

            if (!string.IsNullOrWhiteSpace(Clname))
                query.Eq("CLNAME", Clname);

            if (Qltstatus.HasValue)
                query.Eq("QLTSTATUS", Qltstatus.Value);

            if (Isdel.HasValue)
                query.Eq("ISDEL", Isdel.Value);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
