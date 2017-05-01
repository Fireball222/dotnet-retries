using System;
using RRTools.DotNetRetries;
using Xunit;

namespace UnitTests
{
    public class RetryTests
    {
        [Fact]
        public void CanJustExecuteActionWithoutException()
        {
            // Arrange
            var run = false;

            // Act
            Retry.While<Exception>(() => run = true, 1, TimeSpan.Zero);
            
            // Assert
            Assert.True(run);
        }
    }
}
