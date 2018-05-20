using ADOToolbox;
using Model.Global.Mappers;
using Model.Global.Models;
using Patterns.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Global.Services
{
    public class CarRepository : IDataService<int, Car>
    {
        public Car Add(Car model)
        {
            Connection context = AccessLocator.Instance.TestConnection;
            Command cmd = new Command("INSERT INTO Car(Model, Brand, Price, Kilometers, [Year], [New]) OUTPUT inserted.* VALUES(@Model, @Brand, @Price, @Kilometers, @Year, @New)");
            cmd.AddParameter("Model", model.Model);
            cmd.AddParameter("Brand", model.Brand);
            cmd.AddParameter("Price", model.Price);
            cmd.AddParameter("Year", model.Year);
            cmd.AddParameter("Kilometers", model.Kilometers);
            cmd.AddParameter("New", model.New);

            return context.ExecuteReader(cmd, c => c.ToCar()).SingleOrDefault();
        }

        public IEnumerable<Car> Get()
        {
            Connection context = AccessLocator.Instance.TestConnection;
            Command cmd = new Command("SELECT * FROM Car");
            return context.ExecuteReader(cmd, c => c.ToCar());
        }

        public Car Get(int ID)
        {
            Connection context = AccessLocator.Instance.TestConnection;
            Command cmd = new Command("SELECT * FROM Car WHERE ID = @ID");
            cmd.AddParameter("ID", ID);

            return context.ExecuteReader(cmd, c => c.ToCar()).SingleOrDefault();
        }

        public void Remove(int ID)
        {
            Connection context = AccessLocator.Instance.TestConnection;
            Command cmd = new Command("DELETE FROM Car WHERE ID = @ID");
            cmd.AddParameter("ID", ID);

            context.ExecuteNonQuery(cmd);
        }

        public Car Update(Car model)
        {
            Connection context = AccessLocator.Instance.TestConnection;
            Command cmd = new Command("UPDATE Car  SET model = @Model, brand = @Brand, price = @Price, kilometers = @Kilometers, [Year] = @Year, [New] = @New OUTPUT inserted.* WHERE ID = @ID");
            cmd.AddParameter("Model", model.Model);
            cmd.AddParameter("Brand", model.Brand);
            cmd.AddParameter("Price", model.Price);
            cmd.AddParameter("Year", model.Year);
            cmd.AddParameter("Kilometers", model.Kilometers);
            cmd.AddParameter("New", model.New);
            cmd.AddParameter("ID", model.ID);

            return context.ExecuteReader(cmd, c => c.ToCar()).SingleOrDefault();
        }
    }
}
