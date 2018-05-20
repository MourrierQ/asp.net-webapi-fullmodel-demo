using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Global.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public double Kilometers { get; set; }
        public int Year { get; set; }
        public bool New { get; set; }
    }
}
