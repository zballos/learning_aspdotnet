using EZ.MvcDotNet.Infra.Data.Interfaces;
using Microsoft.Practices.ServiceLocation;

namespace EZ.MvcDotNet.Application
{
    public class AppService
    {
        private IUnitOfWork _uow;

        public void BeginTransaction()
        {
            _uow = ServiceLocator.Current.GetInstance<IUnitOfWork>();
            _uow.BeginTransaction();
        }

        public void Commit()
        {
            _uow.SaveChanges();
        }
    }
}