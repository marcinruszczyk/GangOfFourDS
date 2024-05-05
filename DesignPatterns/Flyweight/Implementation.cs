using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    interface IShape
    {
        void Draw(int x , int y);
    }

    class Circle : IShape
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
            Console.WriteLine("Creating Circle with radius" + radius);
        }

        public void Draw(int x , int y) 
        {
            Console.WriteLine($"Creating Circle at ({x}, {y}) with radius {radius}");
        }
    }

    class ShapeFactory
    {
        private Dictionary<int, IShape> shapes = new Dictionary<int, IShape>();

        public IShape GetCircle(int radius)
        {
            if (!shapes.ContainsKey(radius))
            {
                shapes[radius] = new Circle(radius);
            }
            return shapes[radius];
        }
    }



}
