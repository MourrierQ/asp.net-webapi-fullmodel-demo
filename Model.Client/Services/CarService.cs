using C = Model.Client.Models;
using G = Model.Global.Models;
using Patterns.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Client.Mappers;

namespace Model.Client.Services
{
    public  class CarService : IDataService<int, C.Car>
    {
        public  C.Car Add(C.Car model)
        {
            return GlobalServicesLocator.Instance.CarRepository.Add(model.ToGlobal()).ToClient();
        }

        public IEnumerable<C.Car> Get()
        {
            return GlobalServicesLocator.Instance.CarRepository.Get().Select(c => c.ToClient());
        }

        public C.Car Get(int ID)
        {
            return GlobalServicesLocator.Instance.CarRepository.Get(ID).ToClient();
        }

        public void Remove(int ID)
        {
            GlobalServicesLocator.Instance.CarRepository.Remove(ID);
        }

        public C.Car Update(C.Car model)
        {
            return GlobalServicesLocator.Instance.CarRepository.Update(model.ToGlobal()).ToClient();
        }
    }
}
