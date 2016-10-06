using System;
using System.Data.Entity;

namespace PeopleSearchAtHealthCatalyst.Repository
{
    public abstract class RepositoryBase<C> : IDisposable
        where C : DbContext, new()
    {
        private C _DataContext;

        protected virtual C DataContext
        {
            get
            {
                if (_DataContext == null)
                {
                    _DataContext = new C();
                    AllowSerialization = true;
                }
                return _DataContext;
            }
        }

        protected virtual bool AllowSerialization
        {
            get
            {
                return _DataContext.Configuration.ProxyCreationEnabled;
            }
            set
            {
                _DataContext.Configuration.ProxyCreationEnabled = !value;
            }
        }
        
        public virtual void Dispose()
        {
            if (DataContext != null) DataContext.Dispose();
        }
    }
}