﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Car
    {
        private readonly List<string> _part = new List<string>();
        private readonly string _carType;

        public Car(string carType)
        {
            _carType = carType;
        }

        public void AddPart(string part)
        {
            _part.Add(part);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var part in _part)
            {
                sb.Append($"Car of type {_carType} {part}");
            }
            return sb.ToString();
        }
    }


    //Builder
    public abstract class CarBuilder
    {
        public Car Car { get; private set; }

        public CarBuilder(string carType)
        {
            Car = new Car(carType);
        }

        public abstract void BuildEngine();
        public abstract void BuildFrame();
    }


    //ConcreteBuilder 

    public class MiniBuilder : CarBuilder
    {
        public MiniBuilder()
            : base("Mini")
        {
            
        }

        public override void BuildEngine()
        {
            Car.AddPart("'not a V8'");
        }

        public override void BuildFrame()
        {
            Car.AddPart("'3-door with stripes'");
        }
    }


    public class BMWBuilder : CarBuilder
    {
        public BMWBuilder()
            : base("BMW")
        {
            
        }

        public override void BuildEngine()
        {
            Car.AddPart("'a fancy V8 engine'");
        }

        public override void BuildFrame()
        {
            Car.AddPart("'5-door with metallic finish'");
        }


    }

    //Director

    public class Garage
    {
        private CarBuilder? _builder;

        public Garage()
        {
            
        }

        public void Constructor(CarBuilder builder)
        {
            _builder = builder;

            _builder.BuildEngine();
            _builder.BuildFrame();
        }

        public void Show()
        {
            Console.WriteLine(_builder?.Car.ToString());
        }


    }





}
