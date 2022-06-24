using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hæveautomat___Xunit_test_development_opgave;
using Xunit;

namespace Hæveautomat.Tests
{
    public class OverførselTests
    {
        [Fact]
        public void Overfør_Tests()
        {
            // Arrange 
            double expected = 10000;

            // Act
            double actual = Overførsel.Overfør(53000);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData]
        public void Checkpin_IsTrue() 
        {

            // Act
            double actual = Overførsel.Overfør(53000);

            // Assert
            Assert.Equal();
        }
    }
}
