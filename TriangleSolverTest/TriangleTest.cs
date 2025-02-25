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

        //Test Case - 5 = Scalene  Triangle
        [Test]
        public void ScaleneTriangleTest1()
        {
            // Arrange
            int firstSide = 12;
            int secondSide = 10;
            int thirdSide = 20;
            string expected = "Scalene triangle";

            // Act
            string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //Test Case - 6 = Scalene  Triangle
        [Test]
        public void ScaleneTriangleTest2()
        {
            // Arrange
            int firstSide = 12;
            int secondSide = 15;
            int thirdSide = 20;
            string expected = "Scalene triangle";

            // Act
            string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //Test Case - 7 = Scalene  Triangle
        [Test]
        public void ScaleneTriangleTest3()
        {
            // Arrange
            int firstSide = 12;
            int secondSide = 10;
            int thirdSide = 15;
            string expected = "Scalene triangle";

            // Act
            string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //Test Case - 8 = Scalene  Triangle
        [Test]
        public void ScaleneTriangleTest4()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 4;
            int thirdSide = 3;
            string expected = "Scalene triangle";

            // Act
            string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //Test Case - 9 = Scalene  Triangle
        [Test]
        public void ScaleneTriangleTest5()
        {
            // Arrange
            int firstSide = 14;
            int secondSide = 15;
            int thirdSide = 16;
            string expected = "Scalene triangle";

            // Act
            string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        //Verifying a zero length for one or more sides Test Case - 1
        [Test]
        public void ZeroLengthSideTest1()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 0;
            int thirdSide = 10;
            string expected = "Invalid Triangle - a zero has been detected";

            // Act
            string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //Verifying a zero length for one or more sides Test Case - 2
        [Test]
        public void ZeroLengthSideTest2()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 0;
            int thirdSide = 0;
            string expected = "Invalid Triangle - a zero has been detected";

            // Act
            string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //Verifying a zero length for one or more sides Test Case - 3
        [Test]  
        public void ZeroLengthSideTest3()
        {
            // Arrange
            int firstSide = 0;
            int secondSide = 0;
            int thirdSide = 0;
            string expected = "Invalid Triangle - a zero has been detected";

            // Act
            string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        //verifying an invalid response (other than a zero length) Test - 1
        [Test]
        public void InvalidResponseTest1()
        {
            // Arrange
            int firstSide = 1;
            int secondSide = 2;
            int thirdSide = 5;
            string expected = "INVALID!!";

            // Act
            string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //verifying an invalid response (other than a zero length) Test - 2
        [Test]
        public void InvalidResponseTest2()
        {
            // Arrange
            int firstSide = -10;
            int secondSide = 10;
            int thirdSide = 5;
            string expected = "INVALID!!";

            // Act
            string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //verifying an invalid response (other than a zero length) Test - 3
        [Test]
        public void InvalidResponseTest3()
        { 
            // Arrange
            int firstSide = 5;
            int secondSide = 7;
            int thirdSide = 15;
            string expected = "INVALID!!";

            // Act
            string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
