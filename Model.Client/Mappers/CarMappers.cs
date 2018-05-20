using G = Model.Global.Models;
using C = Model.Client.Models;


namespace Model.Client.Mappers
{
    public static class CarMappers
    {
        public static C.Car ToClient(this G.Car Entity)
        {
            return new C.Car(Entity.ID, Entity.Model, Entity.Brand, Entity.Price, Entity.Kilometers, Entity.Year, Entity.New);
        }

        public static G.Car ToGlobal(this C.Car Entity)
        {
            return new G.Car() {
                ID = Entity.ID,
                Model = Entity.Model,
                Brand = Entity.Brand,
                Price = Entity.Price,
                Kilometers = Entity.Kilometers,
                Year = Entity.Year,
                New = Entity.New
            };
        }
    }
}
