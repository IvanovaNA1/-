using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Автомобиль
{
    class Car
    {
        public Car(string brand = "Ford" , string model = "Mustang" , string colour = "Pink", int number = 1 )
        {
            this.brand = brand;
            this.model = model;
            this.colour = colour;
            this.number = number;
        }

        public string brand;
        public string model;
        public string colour;
        public int number;

        public string GetInfo()
        {
            string s = string.Format($"Марка: {brand}\nМодель: {model}\nЦвет: {colour}\n" + $"Номер: {number}\n");
            return s;
        }
    }
}
