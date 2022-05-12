using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest;

namespace UnitTestCalculateArea
{
    [TestClass]
    public class UnitTestAreas
    {
        [TestMethod]
        public void TestTriangleArea()
        {
            var firstNumber = 2;
            var secondNumber = 3;
            var expected = 0.5*firstNumber*secondNumber;

            var actual = Program.TriangleArea(firstNumber, secondNumber);

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void TestSquareArea()
        {
            var firstNumber = 2;
            var secondNumber = 3;
            var expected = firstNumber * secondNumber;

            var actual = CalculateAreas.squareArea(firstNumber, secondNumber);

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void TestRectangleArea()
        {
            var firstNumber = 2;
            var secondNumber = 3;
            var expected = firstNumber * secondNumber;

            var actual = CalculateAreas.rectangleArea(firstNumber, secondNumber);

            Assert.AreEqual(expected, actual);
        }
    }
}
