using Model.Global.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Global.Mappers
{
    internal static class DBCarMapper
    {
        public static Car ToCar(this IDataRecord reader)
        {
            return new Car()
            {
                ID = (int)reader["ID"],
                Model = reader["Model"].ToString(),
                Brand = reader["Brand"].ToString(),
                Price = Convert.ToDouble(reader["Price"]),
                Kilometers = Convert.ToDouble(reader["Kilometers"]),
                Year = (int)reader["Year"],
                New = (bool)reader["New"]
            };
        }
    }
}
