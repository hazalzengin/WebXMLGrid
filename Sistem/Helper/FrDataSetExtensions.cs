using kk.Ebank.DataAccess;
using kk.Ebank.Mapper;
using System.Collections.Generic;
using System.Data;

namespace Sistem.Helper
{

    public static class FrDataSetExtensions
    {
        public static List<T> ToFrList<T>(this DataSet ds, DbObject dbo, bool loadSubItems) where T : class
        {
            return EntityClassOperations.GetObjectDataTable<T>(ds.Tables[0], dbo, loadSubItems);
        }

        public static List<T> ToFrList<T>(this DataSet ds, DbObject dbo) where T : class
        {
            return EntityClassOperations.GetObjectDataTable<T>(ds.Tables[0], dbo, false);
        }

        public static List<T> ToFrList<T>(this DataSet ds) where T : class
        {
            return EntityClassOperations.GetObjectDataTable<T>(ds.Tables[0], new DbObject(), false);
        }
    }
}
