using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    public class Vehicle
    {
        public Vehicle() { }

        public Vehicle(string make)
        {
            Make = make;
        }

        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public virtual void Start()
        {
            Console.WriteLine("Starting the vehicle");
        }

        public string ToString()
        {
            return $"Proizvoditel: {Make}, Model: {Model}";
        }
    }
}
