
using System;
using System.Collections.Specialized;

namespace Sistem.DB.Service
{
    public class ServiceBase: IDisposable
    {
        private bool disposed = false;

        public StringCollection HataSonuclari { get; set; }

        public ServiceBase()
        {
            HataSonuclari = new StringCollection();
        }

        public void Flush()
        {
            HataSonuclari = new StringCollection();
        }

        ~ServiceBase()
        {
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing == true)
                {
                    // Managed kaynaklar icin 
                }
                // UnManaged kaynaklar icin
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
