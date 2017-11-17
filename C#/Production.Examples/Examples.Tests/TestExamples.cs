using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Examples.Tests
{
    [TestFixture]
    public class TestExamples
    {
        [Test]
        public void Assert_Should_Fail()
        {
            // Arrange
            // Act
            // Assert
            Assert.AreEqual(1, 2);
        }

        [Test]
        public void Assert_Should_Pass()
        {
            // Arrange
            // Act
            // Assert
            Assert.AreEqual(1, 1);
        }
    }
}
