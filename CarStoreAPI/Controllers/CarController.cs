using CarStoreAPI.Utils;
using Model.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarStoreAPI.Controllers
{
    public class CarController : ApiController
    {
        [AcceptVerbs("GET")]
        public IEnumerable<Car> FetchAll()
        {
            return ModelsServicesLocator.Instance.CarService.Get();
        }

        [AcceptVerbs("GET")]
        public Car FetchByID(int ID)
        {
            return ModelsServicesLocator.Instance.CarService.Get(ID);
        }

        [AcceptVerbs("POST")]
        public void AddCar(Car c)
        {
            ModelsServicesLocator.Instance.CarService.Add(c);
        }

        [AcceptVerbs("PUT")]
        public void Update(Car c)
        {
            ModelsServicesLocator.Instance.CarService.Update(c);
        }

        [AcceptVerbs("DELETE")]
        public void Remove(int ID)
        {
            ModelsServicesLocator.Instance.CarService.Remove(ID);
        }
    }
}
