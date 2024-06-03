using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using kk.Ebank.Mapper;
namespace Sistem.DB.Repo
{
    public class AdmDocumentRepo:BaseRepository<AdmDocument> 
    {

        public List<AdmDocument> GetItemClass(int? Id, string Filename, int? Docref, string Docno, string Modul)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_DOCUMENT");

            if(Id.HasValue)
                query.Eq("ID", Id.Value);

            if(!string.IsNullOrWhiteSpace(Filename))
                query.Eq("FILENAME", Filename);

            if(Docref.HasValue)
                query.Eq("DOCREF", Docref.Value);

            if(!string.IsNullOrWhiteSpace(Docno))
                query.Eq("DOCNO", Docno);

            if(!string.IsNullOrWhiteSpace(Modul))
                query.Eq("MODUL", Modul);

            return query.ToDataSet().ToFrList<AdmDocument>();
        }

        public DataSet GetAll(int? Id, string Filename, int? Docref, string Docno, string Modul)
        {
            var query = new FrQueryBase(dbo);
            query.From("ADM_DOCUMENT");

            if (Id.HasValue)
                query.Eq("ID", Id.Value);

            if (!string.IsNullOrWhiteSpace(Filename))
                query.Eq("FILENAME", Filename);

            if (Docref.HasValue)
                query.Eq("DOCREF", Docref.Value);

            if (!string.IsNullOrWhiteSpace(Docno))
                query.Eq("DOCNO", Docno);

            if (!string.IsNullOrWhiteSpace(Modul))
                query.Eq("MODUL", Modul);

            return query.OrderBy("ID", OrderDirection.Desc).ToDataSet();
        }


    }
}
