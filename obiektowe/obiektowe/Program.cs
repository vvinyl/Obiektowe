﻿using System;
using System.Runtime.ConstrainedExecution;
namespace obiektowe {

    public class Car {
        private string _brand;
        private string _model;
        private int _doorCount;
        private float _engineVolume;
        private double _avgConsump;
        private static int _carCount;

        public string Brand { get { return _brand; } set {  _brand = value; } }
        public string Model { get { return _model; } set { _model = value; } }
        public int DoorCount { get { return _doorCount; } set { _doorCount = value; } }
        public float EngineVolume { get { return _engineVolume; } set { _engineVolume = value; } }
        public double AvgConsump { get { return _avgConsump; } set { _avgConsump = value; } }

        public Car() {
            this.Brand = "unknown";
            this.Model = "unknown";
            this.DoorCount = 0;
            this.EngineVolume = 0;
            this.AvgConsump = 0;
            _carCount += 1;
        }
        public Car(string b, string m, int dc, float ev, double ac) {
            this.Brand= b;
            this.Model = m;
            this.DoorCount = dc;
            this.EngineVolume = ev;
            this.AvgConsump = ac;
            _carCount += 1;
        }

        public double CalculateConsump(double roadLength) {
            return (this.AvgConsump * roadLength) / 100;
        }
        public double CalculateCost(double petrolCost, double roadLength) {
            return CalculateConsump(roadLength) * petrolCost;
        }
        public void Details() {
            Console.WriteLine(this.ToString());
        }
        public override string ToString()
        {
            return $"Car | Brand: {_brand}, Model: {_model}, NumOfDoors: { _doorCount}, EngineVol: { _engineVolume}, AvgConsump: { _avgConsump}"; 
}

    }
    
    class Program { 
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Details();
            car1.Brand = "Fiat";
            car1.Model = "126p";
            car1.DoorCount = 2;
            car1.EngineVolume = 650;
            car1.AvgConsump = 6.0;
            car1.Details();
            Car car2 = new Car("Syrena", "105", 2, 0.8f, 7.6d);
            car2.Details();
            Console.WriteLine(car1);
            double routeConsumption = car2.CalculateConsump(500);
            Console.WriteLine($"Route consumption: {routeConsumption} l");
            double routeCost = car2.CalculateCost(500, 5);
            Console.WriteLine($"Route cost: {routeCost}");
        }
    }
}