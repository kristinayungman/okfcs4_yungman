using GeometryShapee;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShape
{
    public class TestRestang
    {
        const int Areaa = 42;
        const int Perimetrr = 26;
        [Fact]
        public void RectangleCorrectArea()
        {
            Restangle rectangle = new Restangle(6, 7);
            Assert.Equal(Areaa, rectangle.Area());
        }
        [Fact]
        public void RectangleCorrectPerimeter()
        {
            Restangle rectangle = new Restangle(6, 7);
            Assert.Equal(Perimetrr, rectangle.Perimeter());
        }
        [Theory]
        [InlineData(-5, 10)]
        [InlineData(0, 2)]
        [InlineData(-5, -10)]
        public void Reastangle_ThrowsArgumentException(double width, double height)
        {
            Assert.Throws<ArgumentException>(() => new Restangle(width, height));
        }
        [Fact]
        public void Restangle_String()
        {
            Restangle rectangle = new Restangle(6, 7);
            //string expected = "Прямоугольник: Ширина = 6, Высота = 7, Площадь = 42, Периметр = 26";
            string result = rectangle.ToString();
            Assert.Contains("\u0428\u0438\u0440\u0438\u043D\u0430 = 6", result); // Ширина = 6
            Assert.Contains("\u0412\u044B\u0441\u043E\u0442\u0430 = 7", result); // Высота = 7
            Assert.Contains("\u041F\u043B\u043E\u0449\u0430\u0434\u044C = 42", result); // Площадь = 42
            Assert.Contains("\u041F\u0435\u0440\u0438\u043C\u0435\u0442\u0440 = 26", result); // Периметр = 26
        }
    }
}
