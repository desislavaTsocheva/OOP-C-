using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCars
{
    internal class Cars
    {
        private string brand;
        private string color;
        private int horsepower;
        private int price;

        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public int Horsepower
        {
            get { return this.horsepower; }
            set { this.horsepower = value; }
        }
        public int Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public Cars(string brand,string color, int horsepower, int price)
        {
            this.brand = Brand;
            this.color = Color;
            this.horsepower = Horsepower;
            this.price = Price;
        }
        public override string ToString()
        {
            return $"Name:{brand},color:{color},horsepower:{horsepower},price$:{price}";
        }
    }
}
