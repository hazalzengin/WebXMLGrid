using kk.Ebank.DataAccess;
using kk.Ebank.Mapper;

namespace Sistem.DB.Repo
{
    public class ProgramConnection
    {

        public static int Program = 0;
        public static string ConStr;

    }

    public class BaseRepository<T> : ObjectAccessor<T> where T : class
    {
        public override void SetConnection()
        {
            if (string.IsNullOrEmpty(ProgramConnection.ConStr))
                dbo = new DbObject(ProgramConnection.Program);
            else
                dbo = new DbObject(ProgramConnection.ConStr);
        }

    }
}
