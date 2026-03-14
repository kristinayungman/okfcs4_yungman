using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryShapee;

namespace TestShape
{
  public class TestTriangle
    {
        const int Areaa = 7;
        const int Perimetrr = 12;
        [Fact]
        public void AreaTriangle()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.Equal(Areaa, triangle.Area());
        }
        [Fact]
        public void PerimetrTriangle()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.Equal(Perimetrr, triangle.Perimeter());
        }
        [Theory]
        [InlineData(1, 2, 4)]
        [InlineData(4, 1, 2)]
        [InlineData(2, 4, 1)]
        public void Treangle_ThrowsArgumentException(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }
    }
}
