using Xunit;
using CarWise.Models;

namespace CarWise.Tests.Models
{
    public class UserTests
    {
        [Fact]
        public void TestUserProperties()
        {
            // Arrange
            int expectedId = 1;
            string expectedUsername = "johndoe";
            string expectedPassword = "secretpassword";

            // Act
            var user = new User
            {
                Id = expectedId,
                Username = expectedUsername,
                Password = expectedPassword
            };

            // Assert
            Assert.Equal(expectedId, user.Id);
            Assert.Equal(expectedUsername, user.Username);
            Assert.Equal(expectedPassword, user.Password);
        }
    }
}

//Test ten sprawdza, czy obiekt klasy User poprawnie zwraca wartości swoich właściwości.
//Tworzony jest obiekt User z przypisanymi wartościami oczekiwanymi do właściwości
//Id, Username i Password, a następnie porównywane są one z wartościami zwracanymi przez te właściwości obiektu User