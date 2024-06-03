using System.Xml.Linq;

namespace Ovning3.Tests
{
    public class AnimalTest
    {
        [Fact]
        public void AskForInitiateAnimal_ShouldReturnAnimalObject()
        {
            //Arrange
            const string expectedName = "Kalle";
            const int expectedAge = 12;
            const bool expectedIsAnimalAllergyFriendly = true;
            
            // Use subclass Dog because Animal is an abstruct class
            var dog = new Dog(expectedName, expectedAge, 12, expectedIsAnimalAllergyFriendly);


            //Act
            var actualName = dog.Name;
            var actualAge = dog.Age;
            var actualIsAnimalAllergyFriendly = dog.IsAllergyFriendly;
            

            //Assert
            Assert.Equal(expectedName, actualName);
            Assert.Equal(expectedAge, actualAge);
            Assert.IsType<bool>(actualIsAnimalAllergyFriendly);

        }
        [Fact]
        public void AskForVirtialMethodStatsToReturnString_ShouldReturnString()
        {
            //Arrange
            const string expectedName = "Kalle";
            const int expectedAge = 12;
            const int expecteWeight = 3;
            const bool expectedIsAnimalAllergyFriendly = true;
            string expected = $"Name: {expectedName}, Age: {expectedAge}, Weight: {expecteWeight} IsAll: {expectedIsAnimalAllergyFriendly}";

            var dog = new Dog(expectedName, expectedAge, expecteWeight, expectedIsAnimalAllergyFriendly);
            var stats = dog.Stats();

            //Act
            var actual = stats;
          

            //Assert
            Assert.True(actual == expected);
        }
    }
}
