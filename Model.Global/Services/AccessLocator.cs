using ADOToolbox;
using Patterns.Locator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Global.Services
{
    internal class AccessLocator : LocatorBase
    {
        private static AccessLocator _instance;

        public static AccessLocator Instance
        {
            get { return _instance ?? (_instance = new AccessLocator()); }
        }

        private AccessLocator()
        {
            Container.Register<Connection>("Data Source=localhost;Initial Catalog=WebAPICarDB;Integrated Security=True", "System.Data.SqlClient");
        }

        public Connection TestConnection => Container.GetInstance<Connection>();

    }
}
