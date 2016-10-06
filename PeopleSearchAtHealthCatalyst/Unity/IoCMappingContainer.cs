using Microsoft.Practices.Unity;
using PeopleSearchAtHealthCatalyst.Controllers;
using PeopleSearchAtHealthCatalyst.Repository;

namespace PeopleSearchAtHealthCatalyst.Unity
{
    public static class IoCMappingContainer
    {
        private static IUnityContainer _Instance = new UnityContainer();

        static IoCMappingContainer() { }

        public static IUnityContainer GetInstance()
        {
            _Instance.RegisterType<DataServiceController>();
            _Instance.RegisterType<IPersonRepository, PersonRepository>(new HierarchicalLifetimeManager());
            return _Instance;
        }
    }
}