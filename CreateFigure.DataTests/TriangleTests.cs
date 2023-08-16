using CreateFigure.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFigure.DataTests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        [DataRow(2, 3, 8)]
        [DataRow(6.8, 2.1, 10.5)]
        public void TriangleIsNotExistsTest(double a, double b, double c)
        {
            Triangle tr = new Triangle(a, b, c);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        [DataRow(4.6, 0, 2.1)]
        [DataRow(1, 0, 4)]
        public void TriangleSideIsZeroTest(double a, double b, double c)
        {
            Triangle tr = new Triangle(a, b, c);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        [DataRow(4.6, -3.5, 2.1)]
        [DataRow(3, 4, -5)]
        public void TriangleSideLessThanZeroTest(double a, double b, double c)
        {
            Triangle tr = new Triangle(a, b, c);
        }

        [TestMethod()]
        [DataRow(new double[] { 5, 3, 7 }, 6.49519)]
        [DataRow(new double[] { 22, 30, 15 }, 157.93966)]
        public void TriangleSquareAreEqualTest(double[] array, double expectedResult)
        {
            Triangle tr = new Triangle(array[0], array[1], array[2]);
            Assert.AreEqual(tr.Square, expectedResult, 0.00001, "Reasult out of range");
        }

        [TestMethod()]
        [DataRow(3, 4, 5)]
        [DataRow(17.46, 23.28, 29.1)]
        public void TriangleIsRightTest(double a, double b, double c)
        {
            Triangle tr = new Triangle(a, b, c);
            Assert.IsTrue(tr.IsRightTriangle());
        }

        [TestMethod()]
        [DataRow(3, 4, 6)]
        [DataRow(18, 23.28, 29.1)]
        public void TriangleIsNotRightTest(double a, double b, double c)
        {
            Triangle tr = new Triangle(a, b, c);
            Assert.IsFalse(tr.IsRightTriangle());
        }
    }
}