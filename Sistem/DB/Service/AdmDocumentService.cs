using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmDocumentService : ServiceBase 
    {
        private readonly AdmDocumentRepo _itemRepo;

        public AdmDocumentService(string conStr="")
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmDocumentRepo();
        } 

        public int Add(AdmDocument item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmDocument item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmDocument> GetItemClass(int? Id, string Filename, int? Docref, string Docno, string Modul)
        {
            return  _itemRepo.GetItemClass(Id, Filename, Docref, Docno, Modul);
        }

        public DataSet GetAll(int? Id, string Filename, int? Docref, string Docno, string Modul)
        {
            return _itemRepo.GetAll(Id, Filename, Docref, Docno, Modul);
        }

    }
}
