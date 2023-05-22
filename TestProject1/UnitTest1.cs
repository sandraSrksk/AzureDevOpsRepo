using Xunit;

namespace YourUnitTestProjectNamespace
{
    public class YourUnitTestClassName
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            int a = 2;
            int b = 3;

            // Act
            int result = a + b;

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            string name = "John Doe";

            // Act
            int length = name.Length;

            // Assert
            Assert.Equal(8, length);
        }

        [Fact]
        public void Test3()
        {
            // Arrange
            int x = 10;
            int y = 5;

            // Act
            int result = x / y;

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test4()
        {
            // Arrange
            string message = "Hello, World!";

            // Act
            string upperCaseMessage = message.ToUpper();

            // Assert
            Assert.Equal("HELLO, WORLD!", upperCaseMessage);
        }
    }
}
