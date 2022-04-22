using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Rectangle
    {
        private double _lenght;
        private double _width;

        public Rectangle()
        {

        }
        public Rectangle(double lenght, double width, string color)
        {
            Lenght = lenght;
            Width = width;
            Color = color;
        }
        public string Color { get; set; }

        public double Lenght
        {
            get
            {
                return _lenght;
            }
            set
            {
                if (value < 0)
                { 
                    throw new ArgumentException("");

                } 
                _lenght = value;
            }
        }
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("");
                }
                _width = value;
            }
        }
    } 
}
