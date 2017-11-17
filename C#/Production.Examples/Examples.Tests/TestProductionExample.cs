using NUnit.Framework;
using Production.Examples;

namespace Examples.Tests
{
    [TestFixture]
    public class TestProductionExample
    {
        [Test]
        public void GiveMeSomthing_Should_ReturnSomething()
        {
            // Arrange
            var sut = new ProductionExample();
            // Act
            var result = sut.GiveMeSomthing();
            // Assert
            Assert.AreEqual(result, "something");
        }
    }
}