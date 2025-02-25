using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit;
using NUnit.Framework;
//using NUnitDemonstration;

namespace TriangleSolverTest
{
    [TestFixture]
    public class TriangleTest
    {

        //Test Case - 1 = Equilateral Triangle
        [Test]
        public void EquilateralTriangleTest1()
        {
            // Arrange
            int firstSide = 10;
            int secondSide = 10;
            int thirdSide = 10;
            string expected = "Equilateral triangle";

            // Act
            string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        //Test Case - 2 = Isosceles Triangle
        [Test]
        public void IsoscelesTriangleTest1()
        {
            // Arrange
            int firstSide = 20;
            int secondSide = 20;
            int thirdSide = 15;
            string expected = "Isosceles triangle";

            // Act
            string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        //Test Case - 3 = Isosceles Triangle
        [Test]
        public void IsoscelesTriangleTest2()
        {
            // Arrange
            int firstSide = 10;
            int secondSide = 20;
            int thirdSide = 20;
            string expected = "Isosceles triangle";

            // Act
            string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        //Test Case - 4 = Isosceles Triangle
        [Test]
        public void IsoscelesTriangleTest3()
        {
            // Arrange
            int firstSide = 20;
            int secondSide = 10;
            int thirdSide = 20;
            string expected = "Isosceles triangle";

            // Act
            string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
