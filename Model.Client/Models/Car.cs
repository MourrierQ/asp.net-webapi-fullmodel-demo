using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Client.Models
{
    public class Car
    {
        private int _ID;
        private string _model;
        private string _brand;
        private double _price;
        private double _kilometers;
        private int _year;
        private bool _new;

        public int ID
        {
            get { return _ID; }
            private set { _ID = value; }
        }


        public string Model
        {
            get { return _model; }
            private set { _model = value; }
        }


        public string Brand
        {
            get { return _brand; }
            private set { _brand = value; }
        }


        public double Price
        {
            get { return _price; }
            private set { _price = value; }
        }


        public double Kilometers
        {
            get { return _kilometers; }
            private set { _kilometers = value; }
        }


        public int Year
        {
            get { return _year; }
            private set { _year = value; }
        }


        public bool New
        {
            get { return _new; }
            private set { _new = value; }
        }


        internal Car(int ID, string Model, string Brand, double Price, double Kilometers, int Year, bool New)
        {
            this.ID = ID;
            this.Model = Model;
            this.Brand = Brand;
            this.Price = Price;
            this.Kilometers = Kilometers;
            this.Year = Year;
            this.New = New;
        }

       
        public Car(string Model, string Brand, double Price, double Kilometers, int Year, bool New, int ID = 0)
        {
            this.ID = ID;
            this.Model = Model;
            this.Brand = Brand;
            this.Price = Price;
            this.Kilometers = Kilometers;
            this.Year = Year;
            this.New = New;
        }


    }
}
