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
        [Test]
        public void Test1()
        {
            // Arrange
            int firstAngle = 3;
            int secondAngle = 3;
            int thirdAngle = 3;
            string expected = "Equilateral triangle";

            // Act
            string actual = TriangleSolver.Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
