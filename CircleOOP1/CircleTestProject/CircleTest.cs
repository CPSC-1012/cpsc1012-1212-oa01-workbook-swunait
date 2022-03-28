using CircleOOP1;   // for Circle
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircleTestProject
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void DefaultConstructor_DefaultRadius_ValidRadius()
        {
            // Arrange 
            Circle circle1 = new Circle();

            // Act

            // Assert
            // The radius of circle1 should be 1,
            // area should be 3.14159
            // perimeter should be 6.28
            Assert.AreEqual(1, circle1.Radius);
            Assert.AreEqual(3.14159, circle1.Area(), 0.005);
            Assert.AreEqual(6.28, circle1.Perimeter(), 0.005);
        }
    }
}
