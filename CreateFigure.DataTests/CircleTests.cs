using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CreateFigure.Data.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        [DataRow(0)]
        public void CircleRadiusIsVeroTest(double param)
        {
            Circle cr = new Circle(param);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        [DataRow(-1.8)]
        [DataRow(-1)]
        [DataRow(-5.2)]
        public void CircleRadiusIsNegativeNumberTest(double param)
        {
            Circle cr = new Circle(param);
        }

        [TestMethod()]
        [DataRow(3, 28.274334)]
        [DataRow(5.25, 86.590148)]
        public void CircleSquareAreEqualTest(double param, double expectedResult)
        {
            Circle cr = new Circle(param);
            Assert.AreEqual(cr.Square, expectedResult, 0.00001, "Reasult out of range");
        }
    }
}