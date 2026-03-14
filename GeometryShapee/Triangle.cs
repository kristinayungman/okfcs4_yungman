using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShapee
{
    public class Triangle
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            if (SideA + SideB <= SideC)
            {
                throw new ArgumentException("Такой треугольник не может существовать!");
            }
            if (SideA + SideC <= SideB)
            {
                throw new ArgumentException("Такой треугольник не может существовать!");
            }
            if (SideC + SideB <= SideA)
            {
                throw new ArgumentException("Такой треугольник не может существовать!");
            }
        }
        public double Perimeter()
        {
            return SideA + SideB + SideC;
        }
        public double Area()
        {
            return Math.Sqrt((Perimeter() / 2) * ((Perimeter() / 2) - SideA) * ((Perimeter() / 2) - SideB) * ((Perimeter() / 2) - SideC));
        }
        public string ToString()
        {
            return $"Треугольник: Первая сторона = {SideA}, Вторая сторона = {SideB}, Третья сторона = {SideC},\n Периметр = {Perimeter()} , Площадь = {Area()}";
        }

    }
}
