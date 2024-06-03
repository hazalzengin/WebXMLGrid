using System;

namespace Sistem.DB.Model
{
    public class BaseModel : IDisposable, ICloneable
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        private bool disposed = false;
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
