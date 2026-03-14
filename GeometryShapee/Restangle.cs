using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShapee
{
    public class Restangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Restangle(double width, double height)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentException("Неккоректный ввод!");
            }

            Width = width;
            Height = height;
        }

        public double Area()
        {
            return Width * Height;
        }

        public double Perimeter()
        {
            return 2 * (Width + Height);
        }

        public string ToString()
        {
            return $"Прямоугольник: Ширина = {Width}, Высота = {Height}, Площадь = {Area()}, Периметр = {Perimeter()}";
        }



    }
}
