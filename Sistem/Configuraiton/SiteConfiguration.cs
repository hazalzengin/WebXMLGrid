using System;
using System.Web;

namespace Sistem.Configuraiton
{
    public class SiteConfiguration
    {
        private static string _appPath;
        public static string AppPath
        {
            get
            {


                if (String.IsNullOrEmpty(_appPath))
                {
                    Int32 segments = HttpContext.Current.Request.Url.Segments.Length;
                    string serverPath = HttpContext.Current.Request.Url.ToString().Substring(0, HttpContext.Current.Request.Url.ToString().LastIndexOf(HttpContext.Current.Request.Url.Segments[segments - 2].ToString()));
                    if (serverPath[serverPath.Length - 1] != '/')
                    {
                        serverPath += "/";
                    }
                    _appPath = serverPath;
                }
                return _appPath;
            }
        }

    }
}
