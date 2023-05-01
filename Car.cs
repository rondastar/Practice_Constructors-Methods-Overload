using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Constructors_Methods_Overload
{
    internal class Car
    {
        string _make;
        string _model;
        int _year;
        int _mileage;

        // Default constructor
        public Car()
        {
            _make = "unassigned";
            _model = "unassigned";
            _year = 0;
            _mileage = 0;
        }
        // Constructor - new car
        public Car(string make, string model)
        {
            _make = make;
            _model = model;
            _year = 0;
            _mileage = 0;
        }
        public Car(string make, string model, int year, int mileage)
        {
            _make = make;
            _model = model;
            _year = year;
            _mileage = mileage;
        }

        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }
        public int Year { get => _year; set => _year = value; }
        public int Mileage { get => _mileage; set => _mileage = value; }

        // Displays car information
        public override string ToString()
        {
            return $"{Year} {Make} {Model} - {Mileage}";
        }
    }
}
