using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Sistem.DB.Model;
using Sistem.DB.Repo;

namespace Sistem.DB.Service
{
    public class AdmQltHeadService : ServiceBase 
    {
        private readonly AdmQltHeadRepo _itemRepo;

        public AdmQltHeadService(string conStr)
        {
            ProgramConnection.ConStr = conStr;
           _itemRepo = new AdmQltHeadRepo();
        } 

        public int Add(AdmQltHead item)
        {
            return _itemRepo.Insert(item);
        }

        public int Update(AdmQltHead item)
        {
            return _itemRepo.Update(item);
        }

        public int Delete(int id)
       {
           return _itemRepo.Delete(id);
       }

        public List<AdmQltHead> GetItemClass(int? Id, int? Paramref, string Analysisno, DateTime? Analysisdate, DateTime? Orderdate_, DateTime? Orderduedate, string Ficheno, int? Stficheref, int? Stlineref, int? Itemref, string Itemcode, int? Clref, string Clcode, string Clname, int? Qltstatus, int? Isdel)
        {
            return  _itemRepo.GetItemClass(Id, Paramref, Analysisno,Analysisdate, Orderdate_, Orderduedate, Ficheno, Stficheref, Stlineref, Itemref, Itemcode, Clref, Clcode, Clname, Qltstatus, Isdel);
        }

        public DataSet GetAll(int? Id, int? Paramref, string Analysisno, DateTime? Analysisdate, DateTime? Orderdate_, DateTime? Orderduedate, string Ficheno, int? Stficheref, int? Stlineref, int? Itemref, string Itemcode, int? Clref, string Clcode, string Clname, int? Qltstatus, int? Isdel)
        {
            return _itemRepo.GetAll(Id, Paramref, Analysisno, Analysisdate, Orderdate_, Orderduedate, Ficheno, Stficheref, Stlineref, Itemref, Itemcode, Clref, Clcode, Clname, Qltstatus, Isdel);
        }

    }
}
