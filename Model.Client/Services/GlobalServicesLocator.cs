using Model.Global.Services;
using Patterns.Locator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Client.Services
{
    internal class GlobalServicesLocator : LocatorBase
    {
        private static GlobalServicesLocator _instance;

        public static GlobalServicesLocator Instance
        {
            get { return _instance ?? (_instance = new GlobalServicesLocator()); }
        }

        private GlobalServicesLocator()
        {
            Container.Register<CarRepository>();
        }

        internal CarRepository CarRepository
        {
            get { return Container.GetInstance<CarRepository>(); } 
        }

    }
}
