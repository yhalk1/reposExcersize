using System;
using CalculateAreaProject;
using CalculateMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcAreaTests
{
    [TestClass]
    public class CalculateAreaTests
    {
        private CalculateAreas CalculateAreas { get; set; }

        [TestInitialize]
        public void TestInit()
        {
            CalculateAreas = new CalculateAreas();
        }

        [DataTestMethod]
        [DataRow(1, 2, 1)]
        [DataRow(2, 4, 4)]
        public void TriangleAreaTest(double a, double h, double expected)
        {
            //act
            double actual = CalculateAreas.TriangleArea(a, h);

            //assert
            Assert.AreEqual(expected, actual, "Triangle square was calculate incorrectly");
        }

        [DataTestMethod]
        [DataRow(2, 4)]
        [DataRow(3, 9)]
        public void SquareAreaTest(double a, double expected)
        {
            //act
            double actual = CalculateAreas.SquareArea(a);

            //assert
            Assert.AreEqual(expected, actual, "Square area was calculate incorrectly");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            CalculateAreas = null;
        }

        
    }
}
