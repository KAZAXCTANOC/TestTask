using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskClassLibrary.Figures;

namespace Tests.Tests
{
    [TestFixture]
    public class FigureTests
    {
        [Test]
        [TestCase(1)]
        [TestCase(-1)]
        [TestCase(0)]
        public void CreateCircles(double raduis)
        {
            if (raduis <= 0)
            {
                Assert.Throws<Exception>(() => { Circle _ = new Circle(raduis); });

            }
            else
            {
                Assert.DoesNotThrow(() => { Circle _ = new Circle(raduis); });
            }
        }

        [Test]
        [TestCase(1, 1, 1)]
        [TestCase(-1, 1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 1, -1)]
        [TestCase(0, 1, 1)]
        [TestCase(1, 0, 1)]
        [TestCase(1, 1, 0)]
        public void CreateTriangles(double sideFirst, double sideSecond, double sideThird)
        {
            if (sideFirst <= 0 || sideSecond <= 0 || sideThird <= 0)
            {
                Assert.Throws<Exception>(() => { Triangle _ = new Triangle(sideFirst, sideSecond, sideThird); });
            }
            else
            {
                Assert.DoesNotThrow(() => { Triangle _ = new Triangle(sideFirst, sideSecond, sideThird); });
            }
        }

        [Test]
        [TestCase(1)]
        [TestCase(5)]
        [TestCase(99999)]
        public void AreaCircleCalculation(int radius)
        {
            var Circle = new Circle(radius);
            Assert.DoesNotThrow(() => { Circle.GetArea(); });
        }

        [Test]
        [TestCase(4, 5, 8)]
        [TestCase(4, 5, 6)]
        [TestCase(5.5, 5.9, 9.3)]

        public void AreaTriangleCalculation(double sideFirst, double sideSecond, double sideThird)
        {
            var Triangle = new Triangle(sideFirst, sideSecond, sideThird);
            Assert.DoesNotThrow(() => { Triangle.GetArea(); });
        }

        [Test]
        [TestCase(4,5,3,true)]
        [TestCase(4,5,7,false)]
        public void TriangleRectangularTest(double sideFirst, double sideSecond, double sideThird, bool result)
        {
            var Triangle = new Triangle(sideFirst, sideSecond, sideThird);
            if (result)
            {
                Assert.IsTrue(Triangle.GetTriangleRectangular());
            }
            else
            {
                Assert.IsFalse(Triangle.GetTriangleRectangular());
            }
        }
    }
}
