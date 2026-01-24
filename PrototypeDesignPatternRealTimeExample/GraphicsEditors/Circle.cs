using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesignPatternRealTimeExample.GraphicsEditors
{
    public class Circle : IShapePrototype
    {

        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }
        public string Color { get; set; }
        public IShapePrototype Clone()
        {
            return new Circle
            {
                X = this.X,
                Y = this.Y,
                Radius = this.Radius,
                Color = this.Color
            };
        }

        public void Display()
        {
            Console.WriteLine($"Circle at ({X}, {Y}) | Radius: {Radius} | Color: {Color}");
        }
    }
}
