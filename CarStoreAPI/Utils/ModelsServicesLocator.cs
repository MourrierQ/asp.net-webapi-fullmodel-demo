using Model.Client.Services;
using Patterns.Locator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarStoreAPI.Utils
{
    public class ModelsServicesLocator : LocatorBase
    {
        private static ModelsServicesLocator _instance;

        public static ModelsServicesLocator Instance
        {
            get { return _instance ?? (_instance = new ModelsServicesLocator()); }
        }

        private ModelsServicesLocator()
        {
            Container.Register<CarService>();
        }

        internal CarService CarService
        {
            get { return Container.GetInstance<CarService>(); }
        }

    }
}