namespace Ovning3.Tests
{
    public class UseErrorTest
    {
        [Fact]
        public void AskForNothing_ShouldReturnString()
        {
            //Arrange
            var useError = new UseError();
            const string expected = "return some string";

            //Act
            var result = useError.UEMessage();

            //Assert
            Assert.True(result == expected);
        }
    }
}