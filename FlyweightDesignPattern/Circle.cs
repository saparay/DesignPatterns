using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightDesignPattern
{
    internal class Circle : IShape
    {
        public string Color { get; set; }

        private readonly int XCor = 10;
        private readonly int YCor = 20;
        private readonly int Radius = 30;
        public void SetColor(string Color)
        {
            this.Color = Color;
        }
        public void Draw()
        {
            Console.WriteLine("Circle: Draw() [Color : " + Color + ", X Cor : " + XCor + ", YCor : " + YCor + ", Radius : " + Radius);
        }
    }
}
